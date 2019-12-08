using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string equation = "";
        private string input_text = "";
        private int bracket_count = 0;
        private int sign_change_count = 0;

        //계산에 사용됨
        private string[] stack_Array = new string[30];
        private int stack_top = -1;
        //후위연산식에 사용됨
        private char[] char_stack_Array = new char[30];
        private int char_stack_top = -1;

        public Form1()
        {
            InitializeComponent();
        }
        //계산식에 변경이 생기면 계산식을 저장함
        private void textBox_equation_TextChanged(object sender, EventArgs e)
        {
            equation = textBox_equation.Text;
        }
        private void textBox_result_TextChanged(object sender, EventArgs e)
        {
            if (textBox_result.Text == "0")
            {
                input_text = "";
            }
            else
            {
                input_text = textBox_result.Text;
            }
        }
        //숫자버튼 입력구간
        private void button1_Click(object sender, EventArgs e)
        {
            zero_check();
            bracket_check('1');
            input_text += "1";
            textBox_result.Text = input_text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zero_check();
            bracket_check('2');
            input_text += "2";
            textBox_result.Text = input_text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zero_check();
            bracket_check('3');
            input_text += "3";
            textBox_result.Text = input_text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zero_check();
            bracket_check('4');
            input_text += "4";
            textBox_result.Text = input_text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zero_check();
            bracket_check('5');
            input_text += "5";
            textBox_result.Text = input_text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            zero_check();
            bracket_check('6');
            input_text += "6";
            textBox_result.Text = input_text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            zero_check();
            bracket_check('7');
            input_text += "7";
            textBox_result.Text = input_text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            zero_check();
            bracket_check('8');
            input_text += "8";
            textBox_result.Text = input_text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            zero_check();
            bracket_check('9');
            input_text += "9";
            textBox_result.Text = input_text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            zero_check();
            bracket_check('0');
            input_text += "0";
            textBox_result.Text = input_text;
        }

        //사칙연산버튼
        private void button_plus_Click(object sender, EventArgs e)
        {
            sign_check('+');
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            sign_check('-');
        }

        private void button_multiplication_Click(object sender, EventArgs e)
        {
            sign_check('*');
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            sign_check('/');
        }

        //+/-버튼 클릭시 동작
        private void button_negate_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text == "0")
            {
                return;
            }
            if (textBox_result.Text.Substring(0, 1) == "-")
            {
                textBox_result.Text = textBox_result.Text.Replace("-", "");
            }
            else
            {
                textBox_result.Text = "-" + textBox_result.Text;
            }
        }
        //결과출력버튼
        private void button_result_Click(object sender, EventArgs e)
        {
            if(equation=="")
            {
                MessageBox.Show("수식을입력하세요");
                return;
            }
            equation_change('=');
        }
        
        //괄호는 여는괄호가 생긴이후에만 닫는괄호를 생성가능
        private void button_Lbracket_Click(object sender, EventArgs e)
        {
            bracket_count++;
            bracket_check('(');
            textBox_equation.AppendText("(");
            if (bracket_count == 0)
            {
                label_bracket_count.Text = "";
            }
            else
            {
                label_bracket_count.Text = bracket_count.ToString();
            }
            input_text = "";
        }
        //닫는괄호입력시 마지막입력이 닫는괄호가 아니면 결과창올리고 닫는괄호면 인풋텍스트를올림
        private void button_Rbracket_Click(object sender, EventArgs e)
        {
            int txtlength = equation.Trim().Length - 1;
            if (bracket_count == 0)
            {
                return;
            }
            bracket_count--;
            input_text = "";
            if (equation.Substring(txtlength, 1) != ")")
            {
                textBox_equation.AppendText(textBox_result.Text + ")");
                equation_change(')');
            }
            else if (equation.Substring(txtlength, 1) == ")")
            {
                textBox_equation.AppendText(input_text + ")");
                equation_change(')');
            }
            if (bracket_count == 0)
            {
                label_bracket_count.Text = "";
            }
            else
            {
                label_bracket_count.Text = bracket_count.ToString();
            }

        }
        //입력창 백스페이스 버튼
        private void button_backspace_Click(object sender, EventArgs e)
        {
            int txtlength = input_text.Trim().Length;
            if (input_text == "")
            {
                return;
            }
            else if (txtlength - 1 == 0)
            {
                textBox_result.Text = "0";
            }
            else
            {
                textBox_result.Text = input_text.Substring(0, txtlength - 1);
            }
        }

        //C는 계산식과 결과 텍스트박스 모두 초기화함
        private void button_C_Click(object sender, EventArgs e)
        {
            textBox_equation.Text = "";
            textBox_result.Text = "0";
            equation = "";
            input_text = "";
            sign_change_count = 0;
            bracket_count = 0;
            label_bracket_count.Text = "";
        }
        //CE는 결과 텍스트박스만 클리어함
        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            input_text = "";
        }


        /*=================
		 *   체크용 함수
		 *=================*/

        //숫자를 입력할때 텍스트박스가 0이면 0을지우고 숫자입력
        void zero_check()
        {
            if (textBox_result.Text == "0")
            {
                textBox_result.Text = "";
            }
        }
        //사칙연산 부호체크
        void sign_check(char sign)
        {
            int txtlength = equation.Trim().Length - 1;
            if (txtlength >= 0 && equation.Substring(txtlength, 1) == "(")
            {
                textBox_equation.Text += textBox_result.Text + sign;
                sign_change_check(sign);
            }
            else if (txtlength >= 0 && equation.Substring(txtlength, 1) == ")")
            {
                textBox_equation.Text += sign;
                sign_change_check(sign);
                equation_change(sign);
            }
            else if (equation != "" && input_text == "")
            {
                if (equation.Substring(txtlength, 1) == sign.ToString())
                {
                    return;
                }
                else if (equation.Substring(txtlength, 1) != sign.ToString())
                {
                    //여기서 +-에서 *,/으로 변경할때 sign_chansge_count변수가 2이상인지 판단하여 전체 괄호를 붙일지 말지 판단
                    if (sign_change_count >= 2)
                    {
                        textBox_equation.Text = "(" + equation.Substring(0, txtlength) + ")" + sign;
                        sign_change_count = 0;
                        equation_change(sign);
                    }
                    else
                    {
                        if (sign == '*' || sign == '/')
                        {
                            if (equation.Substring(txtlength, 1) == "+" || equation.Substring(txtlength, 1) == "-")
                            {
                                sign_change_count--;
                            }
                        }
                        else if (sign == '+' || sign == '-')
                        {
                            if (equation.Substring(txtlength, 1) == "*" || equation.Substring(txtlength, 1) == "/")
                            {
                                sign_change_count++;
                            }
                        }
                        textBox_equation.Text = equation.Substring(0, txtlength) + sign;
                        equation_change(sign);
                    }
                    return;
                }
            }
            else if (equation == "" && input_text == "")
            {
                textBox_equation.AppendText(textBox_result.Text + sign);
                sign_change_check(sign);
                equation_change(sign);
            }
            else if (equation == "" && input_text != "")
            {
                textBox_equation.AppendText(textBox_result.Text + sign);
                sign_change_check(sign);
                equation_change(sign);
            }
            else if (equation != "" && input_text != "")
            {
                textBox_equation.AppendText(textBox_result.Text + sign);
                sign_change_check(sign);
                equation_change(sign);
            }
            //입력이 끝나면 초기화
            input_text = "";

        }

        //닫는괄호후 부호가아닌 숫자나 여는괄호를 입력시 입력오류라 판단하여 이전 괄호내용까지 지워짐
        void bracket_check(char ch)
        {
            int outbracket_count;
            int txtlength = equation.Trim().Length - 1;
            if (equation == "")
            {
                return;
            }
            else if (equation.Substring(txtlength, 1) == ")")
            {
                //숫자와 여는괄호일때 계산식의 역순으로 탐색해서 닫는괄호개수만큼 여는괄호를찾아 계산식제거
                if ((ch >= 48 && ch <= 57) || ch == '(')
                {
                    outbracket_count = 1;
                    while (outbracket_count > 0)
                    {
                        txtlength--;
                        if (equation.Substring(txtlength, 1) == "(")
                        {
                            outbracket_count -= 1;
                        }
                        else if (equation.Substring(txtlength, 1) == ")")
                        {
                            outbracket_count += 1;
                        }
                    }
                    equation = equation.Substring(0, txtlength);
                    textBox_equation.Text = equation;
                }
            }
        }

        //+,-에서 *,/ 입력시 전체괄호가 쳐지는 행위를 위해 체크하는 함수
        void sign_change_check(char ch)
        {
            if (ch == '+' || ch == '-')
            {
                sign_change_count++;
            }
        }

        //부호입력시 계산식을 계산가능한 문자열로 만들어주는 함수
        void equation_change(char ch)
        {
            int txtlength = equation.Trim().Length - 1;
            int temp_bracket;
            string eq = equation.Substring(txtlength, 1);
            string temp_eq;
            if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
            {
                temp_eq = equation.Substring(0, txtlength);
                temp_bracket = bracket_count;
                while (temp_bracket > 0)
                {
                    temp_eq += ")";
                    temp_bracket--;
                }
                cal(temp_eq);
            }
            else if (ch == ')')
            {
                temp_eq = equation.Substring(0, txtlength + 1);
                temp_bracket = bracket_count;
                while (temp_bracket > 0)
                {
                    temp_eq += ")";
                    temp_bracket--;
                }
                cal(temp_eq);
            }
            //=을 눌렀을때 계산식의 끝이 사칙연산 부호라면 입력창의 수를올리고
            //끝이 숫자라면 괄호만 추가, 끝이 닫는괄호라면 괄호만 추가 
            else if (ch == '=')
            {
                if (eq == "+" || eq == "-" || eq == "*" || eq == "/" || eq == "(")
                {
                    equation += textBox_result.Text;
                }

                while (bracket_count > 0)
                {
                    equation += ")";
                    bracket_count--;
                }

                label_bracket_count.Text = bracket_count == 0 ? "" : label_bracket_count.Text;

                cal(equation);
                textBox_equation.Text = "";
            }
        }

        /*=========================
         * 후위연산자 변환추가부분
         *=========================*/

        //계산시 배열의 스택기능을 하는 push,pop함수
        void push(string a)
        {
            stack_Array[++stack_top] = a;
        }
        string pop()
        {
            return stack_Array[stack_top--];
        }
        //후위연산식 변환시 사용하는 push,pop함수
        void char_push(char a)
        {
            char_stack_Array[++char_stack_top] = a;
        }
        char char_pop()
        {
            return char_stack_Array[char_stack_top--];
        }

        //계산식을 후위연산자로 변환해주는 함수
        string[] convert_eq(string eq)
        {
            //eq = "12-6/2-(20+10)";
            string[] postfix_eq = new string[100];
            postfix_eq = Enumerable.Repeat("", 100).ToArray();//배열을 ""로 초기화
            int eq_length = eq.Length;
            char[] eq_charr = eq.ToCharArray();

            int count = 0;
            char temp = ' ';

            for (int i = 0; i < eq_length; i++)
            {
                char a = eq_charr[i];
                if (a == '-')
                {
                    if (temp == ' ' || temp == '+' || temp == '-' || temp == '*' || temp == '/' || temp == '('|| temp == ')' )
                    {
                        postfix_eq[count] += a;
                        temp = a;
                        continue;
                    }
                    else if (temp >= 48 && temp <= 57)
                    {
                        if(char_stack_top>-1)
                        {
                            if(char_stack_Array[char_stack_top] == '*' || char_stack_Array[char_stack_top] == '/')
                            {
                                postfix_eq[++count] += char_pop();
                                if(char_stack_Array[char_stack_top] == '+' || char_stack_Array[char_stack_top] == '-')
                                {
                                    postfix_eq[++count] += char_pop();
                                }
                            }
                        }
                        char_push(a);
                        temp = a;
                        count++;
                        continue;
                    }
                }

                if ((temp >= 48 && temp <= 57) && (a == '+' || a == '-' || a == '*' || a == '/' || a == '(' || a == ')'))
                {
                    count++;
                }

                if (a >= 48 && a <= 57)
                {
                    postfix_eq[count] += a;
                    temp = a;
                    continue;
                }
                else if (a == '+' || a == '-' || a == '*' || a == '/' || a == '(' || a == ')')
                {
                    char x;
                    if(char_stack_top == -1)
                    {
                        x = ' ';
                    }
                    else
                    {
                        x = char_stack_Array[char_stack_top];//가장최근에 스택에 들어간 부호
                    }

                    if(a== '(')
                    {
                        char_push(a);
                    }
                    else if (a=='+'||a=='-')
                    {
                        
                        if (x== '*' || x== '/')
                        {
                            postfix_eq[count++] += char_pop();
                            if(char_stack_Array[char_stack_top] == '+' || char_stack_Array[char_stack_top] == '-')
                            {
                                postfix_eq[count++] += char_pop();
                            }
                            char_push(a);
                        }
                        else if(x == '+' || x == '-')
                        {
                            postfix_eq[count++] += char_pop();
                            char_push(a);
                        }
                        else if(x == '(' || x== ' ')
                        {
                            char_push(a);
                        }
                    }
                    else if (a == '*' || a == '/')
                    {
                        if (x == '*' || x == '/')
                        {
                            postfix_eq[count++] += char_pop();
                            char_push(a);
                        }
                        else if (x == '+' || x == '-' || x == '(' || x==' ')
                        {
                            //if (char_stack_top > -1 && (char_stack_Array[char_stack_top] == '+' || char_stack_Array[char_stack_top] == '-'))
                            //{
                            //    postfix_eq[count++] += char_pop();
                            //}?
                            char_push(a);
                        }
                    }
                    else if (a == ')')
                    {
                        char z = char_pop();
                        while(z != '(')
                        {
                            postfix_eq[count++] += z;
                            z = char_pop();
                        }
                    }
                    temp = a;
                }
            }
            //스택에 남은 연산자를 뒤에붙여줌
            while(char_stack_top >= 0)
            {
                char b = char_pop();
                if (temp>=48 &&temp<=57)
                {
                    postfix_eq[++count] += b;
                }
                else
                {
                    postfix_eq[count++] += b;
                }
            }
            return postfix_eq;
        }

        //계산을 수행하는 함수
        void cal(string str)
        {
            /* 참조에 MSScriptControl을 추가해야 사용이 가능하다.
             * eval함수를 사용해 문자열을 바로 계산해주는 함수
            MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
            sc.Language = "VBScript";
            object rst = sc.Eval(str);
            textBox_result.Text = rst.ToString();
            */
            /*
            * 후위 연산자를 받을 배열생성 test
            *  12-6/2-(20+10)
            *  12 6 2 / - 20 10 + -
            * string[] bk_eq = new string[] { "12", "6", "2", "/", "-", "20", "10", "+", "-","" };
            */

            //MessageBox.Show("str : " + str);
            string[] bk_eq = convert_eq(str);
            int count=0;
            while(bk_eq[count]!="")
            {
                //MessageBox.Show("bk_eq["+count+"] : " + bk_eq[count]);
                count++;
            }
            //MessageBox.Show("count : "+count);
            double rignt_var = 0;
            double left_var=0;

            for (int i = 0; i < count; i++)
            {
                switch (bk_eq[i])
                {
                    case "+":
                        rignt_var = Convert.ToDouble(pop());
                        left_var = Convert.ToDouble(pop());
                        push((left_var + rignt_var).ToString());
                        break;
                    case "-":
                        rignt_var = Convert.ToDouble(pop());
                        left_var = Convert.ToDouble(pop());
                        push((left_var - rignt_var).ToString());
                        break;
                    case "*":
                        rignt_var = Convert.ToDouble(pop());
                        left_var = Convert.ToDouble(pop());
                        push((left_var * rignt_var).ToString());
                        break;
                    case "/":
                        rignt_var = Convert.ToDouble(pop());
                        left_var = Convert.ToDouble(pop());
                        push((left_var / rignt_var).ToString());
                        break;
                    case "":
                        break;
                    default:
                        push(bk_eq[i]);
                        break;
                }
            }
            //MessageBox.Show(pop());
            textBox_result.Text = pop();
            input_text = "";
        }
    }
}
