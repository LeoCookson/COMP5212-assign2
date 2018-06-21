namespace COMP5212.Model
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class Customer
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }


        public Customer(string fn, string ln, string ph)
        {
            FName = fn;
            LName = ln;
            Phone = ph;
        }

        public void GetCustomer()
        {



        }


    }
}
