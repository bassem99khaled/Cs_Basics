using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;
using OOP_Assignment_04.InterFace;
using System.Runtime.InteropServices;
using System.Data;
using System.Net;
using OOP_Assignment_04.Part_02_Q_02;
using OOP_Assignment_04.Part_02_Q03;
namespace OOP_Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 01

            #region Question 1:
            //            What is the primary purpose of an interface in C#?

            //b) To define a blueprint for a class
            #endregion

            #region Question 2:
            // Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private
            //b) protected




            #endregion

            #region Question 3:
            //Can an interface contain fields in C#?

            //b) No

            #endregion

            #region Question 4:
            // In C#, can an interface inherit from another interface?

            //b) Yes, interfaces can inherit from multiple interfaces



            #endregion

            #region Question 5:
            // Which keyword is used to implement an interface in a class in C#?

            // None Of the above

            #endregion

            #region    Question 6:
            //Can an interface contain static methods in C#?

            //a) Yes



            #endregion

            #region Question 7:
            //In C#, can an interface have explicit access modifiers for its members?

            // b) No, all members are implicitly public



        
            #endregion

            #region Question 8:
            //  What is the purpose of an explicit interface implementation in C#?
            // a) To hide the interface members from outside access




            #endregion

            #region Question 9:
            // In C#, can an interface have a constructor?

            // b) No, interfaces cannot have constructors



            #endregion

            #region Question 10:
            // How can a C# class implement multiple interfaces?


            // c) By separating interface names with commas




            #endregion



            #endregion



            #region Parot 02


            #region Question 01:
            //Define an interface named IShape with a property Area and a method DisplayShapeInfo.
            //Create two interfaces, ICircle and IRectangle, that inherit from IShape.Implement these
            //interfaces in classes Circle and Rectangle. Test your implementation
            //by creating instances of both classes and displaying their shape information.






            //ICircle circle = new circle(10);
            //circle.DisplayShapeInfo();


            //IRectangle rectangle = new rectangle(7, 9);
            //rectangle.DisplayShapeInfo();




            #endregion




            #region Question 02:
            //  In this example, we start by defining the IAuthenticationService
            //  interface with two methods: AuthenticateUser and AuthorizeUser.
            //  The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.
            // In the BasicAuthenticationService class
            // the AuthenticateUser method compares the provided username and password with the stored credentials.
            // It returns true if the user is authenticated and false otherwise.
            // The AuthorizeUser method checks if the user with the given username
            // has the specified role.It returns true if the user is authorized and false otherwise.
            //  In the Main method, we create an instance of the BasicAuthenticationService
            //  class and assign it to the authService variable of type IAuthenticationService.
            //  We then call the AuthenticateUser and AuthorizeUser methods using this interface reference.
            //This implementation allows you to switch the authentication service implementation easily
            //by creating a new class that implements the IAuthenticationService interface and providing
            //the desired logic for authentication and authorization.







            //IAuthenticationService authService = new BasicAuthenticationService();


            //string username = "admin";
            //string password = "admin123";
            //if (authService.AuthenticateUser(username, password))
            //{

            //    string role = "Admin";
            //    authService.AuthorizeUser(username, role);
            //}


            //username = "user";
            //password = "wrongpassword";
            //authService.AuthenticateUser(username, password);



            //username = "user";
            //password = "user123";
            //if (authService.AuthenticateUser(username, password))
            //{
            //    string role = "Admin";
            //    authService.AuthorizeUser(username, role);
            //}




            #endregion


            #region  Question 03:
            //we define the INotificationService interface with a method SendNotification
            //that takes a recipient and a message as parameters.
            //We then create three classes: EmailNotificationService, SmsNotificationService,
            //and PushNotificationService, which implement the INotificationService interface.
            //In each implementation, we provide the logic to send notifications through
            //the respective communication channel:
            //The EmailNotificationService class simulates sending an email by outputting
            //a message to the console.
            //The SmsNotificationService class simulates sending an SMS by
            //outputting a message to the console.
            //The PushNotificationService class simulates sending a push notification by
            //outputting a message to the console.
            //In the Main method, we create instances of each notification service class
            //and call the SendNotification method with sample recipient and message values.
            //This implementation allows you to easily switch between different notification channels
            //by creating new classes that implement the INotificationService interface and provide
            //the specific logic for each channel.


       

                //INotificationService emailService = new EmailNotificationService();
                //emailService.SendNotification("user@example.com", "Welcome to our service!");

                
                //INotificationService smsService = new SmsNotificationService();
                //smsService.SendNotification("123-456-7890", "Your OTP is 123456.");

               
                //INotificationService pushService = new PushNotificationService();
                //pushService.SendNotification("user123", "You have a new message!");
       


        #endregion


        #endregion
    }
}
}
