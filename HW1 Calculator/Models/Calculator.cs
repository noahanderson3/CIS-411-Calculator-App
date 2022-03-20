namespace HW1_Calculator.Models
{
    public class Calculator
    {
        public decimal firstInput { get; set; }
        public decimal secondInput { get; set; }
        public decimal result { get; set; }

        public decimal? Calculate(string type)
        {
            switch (type)
            {
                case "add":
                    result = firstInput + secondInput;
                    break;
                case "minus":
                    result = firstInput - secondInput;
                    break;
                case "divide":
                    result = firstInput / secondInput;
                    break;
                case "multiply":
                    result = firstInput * secondInput;
                    break;
            }
                return result;
        }
    }
}
