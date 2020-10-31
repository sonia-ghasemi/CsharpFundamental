

namespace standardcolors
{
    /// <summary>
    /// نمایش 216 رنگ استاندارد در بک کالر فرم و تغییر آن به وسیله دکمه های قبل و بعد
    /// </summary>
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        // سه اندیس ای،جی و کی را بترتیب بعنوان شمارنده                
        // طیف آبی،سبز و قرمز کد رنگ تعریف میکنیم
        // و اندیس ان را بعنوان شمارنده رنگ تعریف می کنیم

        int i, j, k, n = 0;

        private void nextButton_Click(object sender, System.EventArgs e)
        {
            //باتوجه به کد رنگ های استاندارد در مبنای دسیمال 
            //هر اندیس در مبنای ده با فواصل پنجاه و یک تایی افزایش میابد
            //تا زمانی که کوچکتر از 255 باشند 
            //در هنگام تغییر طیف شمارنده طیف های قبلی را 0 میکنیم
            //برای آخرین رنگ(216) این دکمه عمل نمیکند

            if (n == 0)
            {
                i = 0;
                j = 0;
                k = 0;
                previousButton.BackColor = System.Drawing.Color.FromArgb(k, j, i);
                nextButton.BackColor = System.Drawing.Color.FromArgb(k, j, i);
                BackColor = System.Drawing.Color.FromArgb(k, j, i);
                n++;
                countLabel.Text = System.Convert.ToString(n);
                rCodeLabel.Text = System.Convert.ToString(k);
                gCodeLabel.Text = System.Convert.ToString(j);
                bCodeLable.Text = System.Convert.ToString(i);
            }

            else if (i < 255 && n != 0)
            {
                n++;
                i += 51;
                previousButton.BackColor = System.Drawing.Color.FromArgb(k, j, i);
                nextButton.BackColor = System.Drawing.Color.FromArgb(k, j, i);
                BackColor = System.Drawing.Color.FromArgb(k, j, i);
                countLabel.Text = System.Convert.ToString(n);
                rCodeLabel.Text = System.Convert.ToString(k);
                gCodeLabel.Text = System.Convert.ToString(j);
                bCodeLable.Text = System.Convert.ToString(i);
            }

            else if (j < 255 && n != 0)
            {
                n++;
                i = 0;
                j += 51;
                previousButton.BackColor = System.Drawing.Color.FromArgb(k, j, i);
                nextButton.BackColor = System.Drawing.Color.FromArgb(k, j, i);
                BackColor = System.Drawing.Color.FromArgb(k, j, i);
                countLabel.Text = System.Convert.ToString(n);
                rCodeLabel.Text = System.Convert.ToString(k);
                gCodeLabel.Text = System.Convert.ToString(j);
                bCodeLable.Text = System.Convert.ToString(i);
            }

            else if (k < 255 && n != 0)
            {
                n++;
                i = 0;
                j = 0;
                k += 51;
                previousButton.BackColor = System.Drawing.Color.FromArgb(k, j, i);
                nextButton.BackColor = System.Drawing.Color.FromArgb(k, j, i);
                BackColor = System.Drawing.Color.FromArgb(k, j, i);
                countLabel.Text = System.Convert.ToString(n);
                rCodeLabel.Text = System.Convert.ToString(k);
                gCodeLabel.Text = System.Convert.ToString(j);
                bCodeLable.Text = System.Convert.ToString(i);
            }

            //else
            //{
            //    System.Windows.Forms.MessageBox.Show("THE END");
            //}
        }

        private void previousButton_Click(object sender, System.EventArgs e)
        {
            //باتوجه به کد رنگ های استاندارد در مبنای دسیمال 
            //هر اندیس در مبنای ده با فواصل پنجاه و یک تایی کاهش میابد
            //تا زمانی که بزرگتر از 0 باشند 
            //در هنگام تغییر طیف شمارنده طیف های قبلی را 255 میکنیم
            // برای اولین رنگ این دکمه عمل نمیکند

            if (i > 0 && n > 1)
            {
                n--;
                i -= 51;
                previousButton.BackColor = System.Drawing.Color.FromArgb(k, j, i);
                nextButton.BackColor = System.Drawing.Color.FromArgb(k, j, i);
                BackColor = System.Drawing.Color.FromArgb(k, j, i);
                countLabel.Text = System.Convert.ToString(n);
                rCodeLabel.Text = System.Convert.ToString(k);
                gCodeLabel.Text = System.Convert.ToString(j);
                bCodeLable.Text = System.Convert.ToString(i);
            }

            else if (j > 0 && n > 1)
            {
                n--;
                i = 255;
                j -= 51;
                previousButton.BackColor = System.Drawing.Color.FromArgb(k, j, i);
                nextButton.BackColor = System.Drawing.Color.FromArgb(k, j, i);
                BackColor = System.Drawing.Color.FromArgb(k, j, i);
                countLabel.Text = System.Convert.ToString(n);
                rCodeLabel.Text = System.Convert.ToString(k);
                gCodeLabel.Text = System.Convert.ToString(j);
                bCodeLable.Text = System.Convert.ToString(i);
            }

            else if (k > 0 && n > 1)
            {
                n--;
                i = 255;
                j = 255;
                k -= 51;
                previousButton.BackColor = System.Drawing.Color.FromArgb(k, j, i);
                nextButton.BackColor = System.Drawing.Color.FromArgb(k, j, i);
                BackColor = System.Drawing.Color.FromArgb(k, j, i);
                countLabel.Text = System.Convert.ToString(n);
                rCodeLabel.Text = System.Convert.ToString(k);
                gCodeLabel.Text = System.Convert.ToString(j);
                bCodeLable.Text = System.Convert.ToString(i);
            }
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
