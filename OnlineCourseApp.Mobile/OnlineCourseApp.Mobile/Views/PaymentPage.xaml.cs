using OnlineCourseApp.Model;
using OnlineCourseApp.Model.Requests.CourseParticipants;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnlineCourseApp.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentPage : ContentPage
    {
        private readonly APIService _serviceCourseParticipant = new APIService("course-participants");
        private readonly APIService _serviceCourses = new APIService("courses");

        int _courseId = 0;
        public PaymentPage(object CourseId)
        {
            InitializeComponent();
            _courseId = (int)CourseId;
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            var course = await _serviceCourses.GetById<Courses>(_courseId);

            StripeConfiguration.ApiKey = "sk_test_51JBR23Cuc2W2X3gbYx0oUEbPkaFuwGwvhHYj09JXc0VTh5QSlftXVP7eEBy22EXLEnSugjNIrLfJlHjS5hj0m9ka00btdFe9Vz";
            Token stripeToken = null;

            try
            {
                var tokenOptions = new TokenCreateOptions
                {
                    Card = new CreditCardOptions
                    {
                        Number = CreditCardNumber.Text,
                        ExpMonth = Convert.ToInt64(CreditCardExpMonth.Text),
                        ExpYear = Convert.ToInt64(CreditCardExpYear.Text),
                        Cvc = CreditCardSecurityCode.Text
                    }
                };

                var tokenService = new TokenService();
                stripeToken = tokenService.Create(tokenOptions);

                var customer = new CustomerCreateOptions
                {
                    Description = "Course payment",
                    Name = APIService.Username,
                    Source = stripeToken.Id
                };
                var customerService = new CustomerService();
                var customerResponse = customerService.Create(customer);

                // `source` is obtained with Stripe.js; see https://stripe.com/docs/payments/accept-a-payment-charges#web-create-token
                var options = new ChargeCreateOptions
                {
                    Amount = (long)course.Price,
                    Currency = "USD",
                    Customer = customerResponse.Id,
                    Description = "New course payment",
                };

                var service = new ChargeService();
                service.Create(options);

                CourseParticipantsInsertRequest req = new CourseParticipantsInsertRequest
                {
                    CourseId = _courseId,
                    StudentId = APIService.UserId,
                    Comment = "",
                    Review = 0,
                    ParticipationDate = DateTime.Now
                    };

                    await _serviceCourseParticipant.Insert<CourseParticipants>(req);

                    await DisplayAlert("Info", "You have successfuly buy course!", "OK");

                    await Navigation.PopToRootAsync();
                }
            catch (Exception ex)
            {
                await DisplayAlert("Error!", "Invalid data", "OK");
            }

        }
    }
}