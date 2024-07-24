namespace demo_oop_5
{
    class program
    { 
    
    static void main(string[]args)
        {
            #region operator overloading
            //complex c01 = new complex() { real = 3, imag = 5 };
            //Console.WriteLine(c01);

            //complex c02 = new complex() { real = 2, imag = 4 };
            //Console.WriteLine(c02);

            //complex c03 = default;
            #region binary operator overloading
            //c03 = c01 + c02;

            //Console.WriteLine(c03); 
            #endregion
            #region unary operator overloading

            //    c03 = ++c01; //prefix
            //  c03 = c01++; //postfix

            //Console.WriteLine(c03);  
            #endregion
            #region relational operators <,>,>=,<=,==,!=
            // if (c01 < c02)
            //     Console.WriteLine("c01<c02");
            //else if (c01 < c02)
            //     Console.WriteLine("c02<c01");

            // if (c01 == c02)
            //     Console.WriteLine("equal");
            // else if (c01 < c02)
            //     Console.WriteLine("not equal");
            //user User = new user()
            //{
            //    id = 10,
            //    fullname = "tony ehab",
            //    email = "tonyehab@gmail.com",
            //    password = "passsword",
            //    securitystamp = Guid.NewGuid()
            //};


            //userviewmodel Userviewmodel = (userviewmodel)user;

            //Console.WriteLine(Userviewmodel.email);
            //Console.WriteLine(Userviewmodel.firstName);
            //Console.WriteLine(Userviewmodel.lastName); 
            #endregion
            #endregion
            #region casting operators overloading

            //   complex c01 = new complex() {real=2, imag=4 };
            ////   int y = (int)c01;


            //   Console.WriteLine(c01);

            #endregion
            #region abstraction
            //shape Shape = new shape();

            rectangle Rectangle =new rectangle();
            Rectangle.dimo01 = 10;
            Rectangle.dimo02 = 20;
            Rectangle.calcarea();


            square Square = new square(20);
            Square.calcarea();
          decimal squarepere =  Square.perimeter;
            Console.WriteLine($"perimeter of square = {squarepere}");

            circle Circle = new circle(10);
            Circle.calcarea();
            decimal circlepere = Circle.perimeter;
            Console.WriteLine($"perimeter of circle = {circlepere}");




            #endregion

        }








    }



}