using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_test
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            var driver = new ChromeDriver();
            try
            {
                driver.Navigate().GoToUrl("https://www.google.com.tr/");
                var query = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input"));
                query.SendKeys(txt_Search.Text);
                query.Submit();
            }
            catch 
            {
                //hata olması durumunda hata ekranının görüntüsünü alır
                ITakesScreenshot ekrangoruntusual = driver as ITakesScreenshot;
                Screenshot screenshot = ekrangoruntusual.GetScreenshot();

                screenshot.SaveAsFile(@"DOSYA_YOLU_YAZILACAK", ScreenshotImageFormat.Png);
                //ss alınan resmin doysa yolu ve dosya formatını belirledik 
                driver.Quit();
            }


        }

        private void Login_Click(object sender, EventArgs e)
        {
            var driver = new ChromeDriver();
            try
            {
                driver.Navigate().GoToUrl("test-edilecek-websitesi-adresi");
                var email = driver.FindElement(By.Id("textbox_email"));
                var password = driver.FindElement(By.Id("textbox_password"));
                var login = driver.FindElement(By.TagName("Button"));
                login.Click();
            }
            catch 
            {
                ITakesScreenshot ekrangoruntusual = driver as ITakesScreenshot;
                Screenshot screenshot = ekrangoruntusual.GetScreenshot();
                screenshot.SaveAsFile(@"DOSYA_YOLU_YAZILACAK", ScreenshotImageFormat.Png); 
                driver.Quit();
            }

        }
    }
}
