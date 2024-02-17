using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

namespace OpenAI
{
    public class ChatGPT : MonoBehaviour
    {
        [SerializeField] private InputField inputField;
        [SerializeField] private Button button;
        [SerializeField] private ScrollRect scroll;
        
        [SerializeField] private RectTransform sent;
        [SerializeField] private RectTransform received;

        private float height;
        private OpenAIApi openai = new OpenAIApi();

        private List<ChatMessage> messages = new List<ChatMessage>();
        private string prompt = "Твоя роль - помощник-ассистент в нашем приложении. Оно создано для прохождения курсов.Кнопки \"Админ панель, профиль, чатов и кнопка для диалога с тобой находятся в нижней панели. У пользователей есть 2 роли, перподаватель и ученик. Ученик может проходить курсы и задавать вопросы преподавателю. Преподаватель может редактировать курсы и отвечать ученикам в линчных сообщениях.\". Не выходи из роли. Не давай длинные ответы!!!!! Твое ограничение - 20 слов. Не упоминай, что ты AI модель";


        private void Start()
        {
            button.onClick.AddListener(SendReply);
        }

        private void AppendMessage(ChatMessage message)
        {
            scroll.content.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 0);

            var item = Instantiate(message.Role == "user" ? sent : received, scroll.content);
            item.GetChild(0).GetChild(0).GetComponent<Text>().text = message.Content;
            item.anchoredPosition = new Vector2(0, -height);
            LayoutRebuilder.ForceRebuildLayoutImmediate(item);
            height += item.sizeDelta.x;
            
            scroll.content.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
            scroll.verticalNormalizedPosition = 0;
            
        }

        private async void SendReply()
        {
            var newMessage = new ChatMessage()
            {
                Role = "user",
                Content = inputField.text
            };
            
            AppendMessage(newMessage);

            if (messages.Count == 0) newMessage.Content = prompt + "\n" + inputField.text; 
            
            messages.Add(newMessage);
            button.enabled = false;
            inputField.text = "";
            
            inputField.enabled = false;
            
            // Complete the instruction
            var completionResponse = await openai.CreateChatCompletion(new CreateChatCompletionRequest()
            {
                Model = "gpt-3.5-turbo-0613",
                Messages = messages
            });

            if (completionResponse.Choices != null && completionResponse.Choices.Count > 0)
            {
                var message = completionResponse.Choices[0].Message;
                message.Content = message.Content.Trim();
                messages.Add(message);
                AppendMessage(message);
            }
            else
            {
                Debug.LogWarning("Для вашего промта текст не был сгенерирован.");
            }

            button.enabled = true;
            inputField.enabled = true;
        }
    }
}
