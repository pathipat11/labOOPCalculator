#nullable enable
namespace Lab1
{
    public partial class Form1 : Form
    {

        double num1,num2, num3;
        string? op;
        public Form1()
        {
            InitializeComponent();
        }
        //ปุ่ม 9
        private void bt9_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "9";
            Display1.Text = Display1.Text + "9";
        }
        //ปุ่ม 8
        private void bt8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "8";
            Display1.Text = Display1.Text + "8";
        }
        //ปุ่ม 7
        private void bt7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "7";
            Display1.Text = Display1.Text + "7";
        }
        //ปุ่ม 6
        private void bt6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "6";
            Display1.Text = Display1.Text + "6";
        }
        //ปุ่ม 5
        private void bt5_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "5";
            Display1.Text = Display1.Text + "5";
        }
        //ปุ่ม 4
        private void bt4_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "4";
            Display1.Text = Display1.Text + "4";
        }
        //ปุ่ม 3
        private void bt3_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "3";
            Display1.Text = Display1.Text + "3";
        }
        //ปุ่ม 2
        private void bt2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "2";
            Display1.Text = Display1.Text + "2";
        }
        //ปุ่ม 1
        private void bt1_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "1";
            Display1.Text = Display1.Text + "1";
        }
        //ปุ่ม 0
        private void bt0_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + "0";
            Display1.Text = Display1.Text + "0";
        }
        //ปุ่ม .
        private void point_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + ".";
            Display1.Text = Display1.Text + ".";
        }
        //ปุ่ม ลบ
        private void button11_Click(object sender, EventArgs e)
        {
            Display.Text = "";
            Display1.Text = "";
        }
        //ปุ่ม +
        private void button1_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = "";
            Display1.Text = Display1.Text + "+";
            op = "+";
        }
        //ปุ่ม -
        private void button2_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = "";
            Display1.Text = Display1.Text + "-";
            op = "-";
        }
        //ปุ่ม *
        private void button3_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = "";
            Display1.Text = Display1.Text + "x";
            op = "*";
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void Display1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //ปุ่ม /
        private void button4_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Display.Text);
            Display.Text = "";
            Display1.Text = Display1.Text + "÷";
            op = "/";
        }
        //ปุ่ม SUM
        private void button5_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(Display.Text);
            Display1.Text = Display1.Text + "=";
            if (op == "+")
            {
                num3 = num1 + num2;
                
                Display.Text = num3.ToString("#,##0");
            }//close +
            if (op == "-")
            {
                num3 = num1 - num2;
                Display.Text = num3.ToString("#,##0");
            }//close -
            if (op == "*")
            {
                num3 = num1 * num2;
                Display.Text = num3.ToString("#,##0");
            }//close *
            if (op == "/")
            {
                num3 = num1 / num2;
                Display.Text = num3.ToString("#,##0");
            }//close ÷
        }


    }
}
///class' variable
///assing string value to textbox
///string text = "Hello world";
///int iNumber = 0;
///double d = 10.01;
///bool isStudent = false;

///string number1 = this.num1.Text;
///string number2 = this.num2.Text;

///double dNumber1 = 0.0;
///double dNumber2 = 0.0;
///Convert string to double
///dNumber1 = Double.Parse(number1);
///dNumber2 = Double.Parse(number2);
///Convert double to string for display
///double result = (dNumber1 + dNumber2);
///double input
///this.Display.Text = "";