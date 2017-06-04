using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TracingMessageUsingASP.NET
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                int FirstNumber = Convert.ToInt32(txtFirstNumber.Text);
                int SecondNumber = Convert.ToInt32(txtSecondNumber.Text);

                lblMessage.ForeColor = System.Drawing.Color.Navy;
                int Result = FirstNumber / SecondNumber;
                lblMessage.Text = Result.ToString();
            }
            catch (FormatException formatException)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Only numbers are allowed";
                // Check if tracing is enabled
                if (Trace.IsEnabled)
                {
                    // Write the exception message to the trace log
                    Trace.Write(formatException.Message);
                }
            }
            catch (OverflowException overflowException)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Numbers must be between " + Int32.MinValue.ToString() + " and " + Int32.MaxValue.ToString();
                if (Trace.IsEnabled)
                {
                    Trace.Warn(overflowException.Message);
                }
            }
            catch (DivideByZeroException divideByZeroException)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Denominator cannot be ZERO";
                if (Trace.IsEnabled)
                {
                    Trace.Warn(divideByZeroException.Message);
                }
            }
            catch (Exception exception)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "An unknown problem has occured. Please try later";
                if (Trace.IsEnabled)
                {
                    Trace.Warn(exception.Message);
                }
            }
        }
    }
}