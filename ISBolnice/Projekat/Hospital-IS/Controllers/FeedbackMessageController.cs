using ClinicCore.DTOs;
using ClinicCore.Model;
using ClinicCore.Service;
using System.Collections.Generic;

namespace Hospital_IS.Controllers
{
    class FeedbackMessageController
    {
        private static FeedbackMessageController instance = null;
        public static FeedbackMessageController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FeedbackMessageController();
                }
                return instance;
            }
        }

        private FeedbackMessageController()
        {
        }

        public List<FeedbackMessage> GetAll()
        {
            return FeedbackMessageService.Instance.AllMessages;
        }

        public void AddFeedbackMessage(FeedbackMessageDTO message)
        {
            FeedbackMessage feedbackMessage = new FeedbackMessage(message.Text, message.DateSent);
            FeedbackMessageService.Instance.AddFeedbackMessage(feedbackMessage);
        }
    }
}
