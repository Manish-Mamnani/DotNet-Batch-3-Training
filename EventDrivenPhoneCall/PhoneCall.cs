using System;
using System.Collections.Generic;
using System.Text;

namespace EventDrivenPhoneCall
{
    public delegate void Notify();

    public class PhoneCall
    {

        public event Notify PhoneCallEvent;

        public string Message { get; private set; }

        private void OnSubscribe()
        {
            Message = "Subscribed to Call";
        }

        private void OnUnsubscribe()
        {
            Message = "Unsubscribed to Call";
        }

        public void MakeAPhoneCall(bool notify)
        {
            PhoneCallEvent = null;

            if (notify)
            {
                PhoneCallEvent += OnSubscribe;
            }
            else
            {
                PhoneCallEvent += OnUnsubscribe;
            }

            PhoneCallEvent?.Invoke();
        }
    }
}
