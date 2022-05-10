using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace IgnasBaigiamasis.Page
{
    class OBDelevenStage : BasePage
    {
        private const string PageAddress = "https://obdeleven.com/en/";

        private static IWebElement _newsletterBarInput => Driver.FindElement(By.Name("email"));
        private IWebElement _subscribeButton => Driver.FindElement(By.Name("submitNewsletter"));
        private IWebElement _resultSubscription => Driver.FindElement(By.ClassName("swal-text"));
        private IWebElement _livechatOpen => Driver.FindElement(By.Id("desktop-livechat-link"));
        private IWebElement _livechatNewChat => Driver.FindElement(By.CssSelector("#intercom-container > div > div > div.intercom-messenger.intercom-messenger-home-screen.intercom-k9lbvn.e1gli0d30 > div.intercom-1xafcqx.ens34ad0 > div > div > div.intercom-home-screen-messenger-card.intercom-1ttb737.e26ch0o1 > div.intercom-j4nudy.e26ch0o2 > div > div > div > div.intercom-1yuhvjn.e132y98q4 > button"));
        private IWebElement _livechatText => Driver.FindElement(By.Name("message"));
        private IWebElement _livechatSendText => Driver.FindElement(By.ClassName("intercom-composer-send-button"));
        private IWebElement _livechatConfirmText => Driver.FindElement(By.ClassName("intercom-block-paragraph"));
        private IWebElement _livechatClose => Driver.FindElement(By.ClassName("livechat-close"));
        private IWebElement _userInfo => Driver.FindElement(By.CssSelector("#header > div.nav > div > div.header_user_info"));
        private IWebElement _loginButton => Driver.FindElement(By.CssSelector("#header > div.nav > div > div.header_user_info > ul > li:nth-child(2) > a"));
        private IWebElement _enterEmail => Driver.FindElement(By.CssSelector("#login-form > section > div:nth-child(2) > div.col-md-9 > input"));
        private IWebElement _enterPass => Driver.FindElement(By.CssSelector("#login-form > section > div:nth-child(3) > div.col-md-9 > div > input"));
        private IWebElement _initiateLogin => Driver.FindElement(By.CssSelector("#login-form > footer > button"));
        private IWebElement _confirmLogin => Driver.FindElement(By.CssSelector("#main > footer > div > a"));
        private IWebElement _myAccount => Driver.FindElement(By.CssSelector("#header > div.nav > div > div.header_user_info > ul > li:nth-child(1) > a"));
        private IWebElement _myInformation => Driver.FindElement(By.CssSelector("#identity-link > span"));
        private IWebElement _enterOldPass => Driver.FindElement(By.CssSelector("#customer-form > section > div:nth-child(7) > div.col-md-9 > div > input"));
        private IWebElement _enterNewPass => Driver.FindElement(By.CssSelector("#customer-form > section > div:nth-child(8) > div.col-md-9 > div > input"));
        private IWebElement _acceptTerms => Driver.FindElement(By.CssSelector("#customer-form > section > div:nth-child(9) > div.col-md-9 > span > label > input[type=checkbox]"));
        private IWebElement _saveAccount => Driver.FindElement(By.CssSelector("#customer-form > footer > button"));
        private IWebElement _confirmChange => Driver.FindElement(By.CssSelector("#notifications > div > article > ul > li"));
        private IWebElement _logoutButton => Driver.FindElement(By.CssSelector("#header > div.nav > div > div.header_user_info > ul > li:nth-child(3) > a"));
        private IWebElement _openContacts => Driver.FindElement(By.CssSelector("#header > div.nav > div > div.xprt_mega_menu_area.clearfix.sticky > div > ul > li.page_contact > a"));
        private IWebElement _contactsEmail => Driver.FindElement(By.CssSelector("#content > div.container > div > div.col-xs-12.col-sm-12.col-md-6.col-lg-6.col-xl-6.form-col > section > form > section > div:nth-child(2) > div > input"));
        private SelectElement _dropdownSelect => new SelectElement(Driver.FindElement(By.CssSelector("#content > div.container > div > div.col-xs-12.col-sm-12.col-md-6.col-lg-6.col-xl-6.form-col > section > form > section > div:nth-child(3) > div > select")));
        private IWebElement _enterContactsText => Driver.FindElement(By.CssSelector("#content > div.container > div > div.col-xs-12.col-sm-12.col-md-6.col-lg-6.col-xl-6.form-col > section > form > section > div:nth-child(8) > div.col-md-12 > textarea"));
        private IWebElement _confirmRobot => Driver.FindElement(By.CssSelector("#rc-anchor-container > div.rc-anchor-content > div:nth-child(1) > div > div"));
        private IWebElement _sendcontactText => Driver.FindElement(By.CssSelector("#content > div.container > div > div.col-xs-12.col-sm-12.col-md-6.col-lg-6.col-xl-6.form-col > section > form > footer > input"));
        private IWebElement _confirmContactSent => Driver.FindElement(By.CssSelector("#content > div.container > div > div.col-xs-12.col-sm-12.col-md-6.col-lg-6.col-xl-6.form-col > section > form > div > ul > li"));


        public OBDelevenStage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

        public OBDelevenStage InsertEmail(string email)
        {
            _newsletterBarInput.Clear();
            _newsletterBarInput.SendKeys(email);

            return this;
        }

        public OBDelevenStage ClickSubscribeButton()
        {
            _subscribeButton.Click();

            return this;
        }

        public OBDelevenStage CheckIfSuccess(string success)
        {
            Assert.AreEqual(success, _resultSubscription.Text, "Subscription failed");

            return this;
        }

        public OBDelevenStage OpenLiveChat()
        {
            _livechatOpen.Click();

            return this;

        }

        public OBDelevenStage NewChat()
        {
            GetWait(5).Until(d => _livechatNewChat.Displayed);
            _livechatNewChat.Click();

            return this;
        }

        public OBDelevenStage EnterText(string text)
        {
            _livechatText.Clear();
            _livechatText.SendKeys(text);

            return this;
        }
        public OBDelevenStage SendText()
        {
            _livechatSendText.Click();

            return this;
        }
        public OBDelevenStage ConfirmIfTextSent(string textsent)
        {
            Assert.AreEqual(textsent, _livechatConfirmText.Text, "Text incorrect or was not sent");

            return this;
        }
        public OBDelevenStage CloseLiveChat()
        {
            _livechatClose.Click();

            return this;
        }
        public OBDelevenStage ClickUserButton()
        {
            _userInfo.Click();

            return this;
        }
        public OBDelevenStage ClickLoginButton()
        {
            _loginButton.Click();

            return this;
        }
        public OBDelevenStage EnterEmail(string emailentry)
        {
            _enterEmail.Clear();
            _enterEmail.SendKeys(emailentry);

            return this;
        }
        public OBDelevenStage EnterPass(string passentry)
        {
            _enterPass.Clear();
            _enterPass.SendKeys(passentry);

            return this;
        }
        public OBDelevenStage InitiateLogin()
        {
            _initiateLogin.Click();

            return this;
        }
        public OBDelevenStage ConfirmLogin(string confirmtext)
        {
            Assert.AreEqual(confirmtext, _confirmLogin.Text, "Text incorrect or was not sent");

            return this;
        }
        public OBDelevenStage MyAccount()
        {
            _myAccount.Click();

            return this;
        }
        public OBDelevenStage MyInfo()
        {
            _myInformation.Click();

            return this;
        }
        public OBDelevenStage EnterOldPass(string oldpass)
        {
            _enterOldPass.Clear();
            _enterOldPass.SendKeys(oldpass);

            return this;
        }
        public OBDelevenStage EnterNewPass(string newpass)
        {
            _enterNewPass.Clear();
            _enterNewPass.SendKeys(newpass);

            return this;
        }
        public OBDelevenStage AcceptTerms()
        {
            _acceptTerms.Click();

            return this;
        }
        public OBDelevenStage ClickSave()
        {
            _saveAccount.Click();

            return this;
        }
        public OBDelevenStage ConfirmChange(string confirmpass)
        {
            Assert.AreEqual(confirmpass, _confirmChange.Text, "Did not change password");

            return this;
        }
        public OBDelevenStage LogOut()
        {
            _logoutButton.Click();

            return this;
        }

        public OBDelevenStage OpenContacts()
        {
            _openContacts.Click();

            return this;
        }

        public OBDelevenStage EnterContactsEmail(string contactemail)
        {
            _contactsEmail.Clear();
            _contactsEmail.SendKeys(contactemail);

            return this;
        }
        public OBDelevenStage EnterContactsText(string contacttext)
        {
            _enterContactsText.Clear();
            _enterContactsText.SendKeys(contacttext);

            return this;
        }
        public OBDelevenStage SelectFromDropDownByText(string selecttext)
        {
            _dropdownSelect.SelectByText(selecttext);

            return this;
        }

        public OBDelevenStage ConfirmRobot()
        {
            _confirmRobot.Click();

            return this;
        }

        public OBDelevenStage ClickSendContacts()
        {
            _sendcontactText.Click();

            return this;
        }
        public OBDelevenStage ConfirmIfSentContacts(string confirmationsent)
        {
            Assert.AreEqual(confirmationsent, _confirmContactSent.Text, "Did not change send message");

            return this;
        }
    }
}