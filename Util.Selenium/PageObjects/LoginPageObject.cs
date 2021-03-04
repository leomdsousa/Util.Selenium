﻿using OpenQA.Selenium;

namespace Util.Selenium.PageObjects
{
    public class LoginPageObject
    {
        private readonly IWebDriver _driver;

        private const string url = "https://www.imdb.com/ap/signin?openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.imdb.com%2Fregistration%2Fap-signin-handler%2Fimdb_us&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=imdb_us&openid.mode=checkid_setup&siteState=eyJvcGVuaWQuYXNzb2NfaGFuZGxlIjoiaW1kYl91cyIsInJlZGlyZWN0VG8iOiJodHRwczovL3d3dy5pbWRiLmNvbS8_cmVmXz1sb2dpbiJ9&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&tag=imdbtag_reg-20";
        private IWebElement User => _driver.FindElement(By.Id("ap_email"));
        private IWebElement Password => _driver.FindElement(By.Id("ap_password"));
        private IWebElement SignInSubmit => _driver.FindElement(By.Id("signInSubmit"));

        public LoginPageObject(IWebDriver driver) 
        {
            _driver = driver;
        }
        public IWebDriver Login(string username, string password)
        {
            User.SendKeys(username);
            Password.SendKeys(password);
            SignInSubmit.Click();

            return _driver;
        }
        public string Url()
        {
            return url;
        }
    }
}
