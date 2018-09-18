using System;

namespace MockingDemo._03
{
    public class BillingViewModel
    {
        private readonly IBillingSystem billingSystem;

        public BillingViewModel(IBillingSystem billingSystem)
        {
            this.billingSystem = billingSystem;
        }

        public void SubmitForm(Form form)
        {
            if (form.IsValid)
            {
                this.billingSystem.Process();
            }
        }

        public class Form
        {
            public bool IsValid { get; set; }
        }
    }
}
