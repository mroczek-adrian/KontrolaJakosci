using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using System.Threading;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;

namespace UIPutttyTests
{
    [TestClass]
    public class SCEntry01_AutomatyzacjaTest1
    {
        private Application App;

        private readonly string appPath = @"C:\Program Files (x86)\Password Safe\pwsafe.exe";
        private const string path = "‪C:\\Users\\Adrian\\pwsafe.psafe3";
        private const string APP_TITLE = "Safe Combination Entry";
        //  private const string APP_TITLEBAR_ID = "TitleBar";
        private const string APP_VERSION = "V3.47.02";
        private const string ITEM_DEFAULT = "Default Settings";
        private const string ITEM_127_0_0_1 = "127.0.0.1";
        private const string OpenAS = "Open as read-only";
        private const string pass = "Show Combination";

    
       
        private int sleepTimeShort = 500;
        private int sleepTimeNormal = 2000;
        private int sleepTimeLong = 3000;

        [TestMethod]
        public void SCEntry01_Title()
        {
            App = Application.Launch(appPath);
            Thread.Sleep(sleepTimeNormal);

            Window window = App.GetWindow(APP_TITLE);

            Assert.AreEqual(APP_TITLE, window.Title, "Asercja 01: Sprawdzenie tytułu aplikacji");

            window.Close();
        }
        
        /*
         * [TestMethod]
        public void SCEntry01_StartedPath()
        {
            App = Application.Launch(appPath);
            Thread.Sleep(sleepTimeNormal);

            Window window = App.GetWindow(APP_TITLE);


            TextBox lbx = window.Get<TextBox>(SearchCriteria.ByClassName("Edit"));
            //Button btnNew = window.Get<Button>(SearchCriteria.ByText("New..."));
            //btnNew.Click();
            // TitleBar lbx = window.Get<TitleBar>(SearchCriteria.ByClassName("TitleBar"));
            Assert.AreEqual(path, lbx.Name, "Asercja 08: Sprawdzenie sciezki do bazy z haslami");
            //   Assert.AreEqual(ITEM_DEFAULT, lbx.Items[0].Text, "Asercja 05: Sprawdzenie wartości pierwszej zapisanej sesji");
            //    Assert.AreEqual(ITEM_127_0_0_1, lbx.Items[1].Text, "Asercja 06: Sprawdzenie wartości drugiej zapisanej sesji");
            //    Thread.Sleep(sleepTimeShort);

            window.Close();

        }
        */
    }
    [TestClass]
    public class SCEntry02_AutomatyzacjaTest2
    {
        private Application App;
        private readonly string appPath = @"C:\Program Files (x86)\Password Safe\pwsafe.exe";
        private const string path = "‪C:\\Users\\Adrian\\pwsafe.psafe3";

        private const string APP_TITLE = "Safe Combination Entry";
        //  private const string APP_TITLEBAR_ID = "TitleBar";
        private const string APP_VERSION = "V3.57";
        private const string ITEM_DEFAULT = "Default Settings";
        private const string ITEM_127_0_0_1 = "127.0.0.1";
        private const string OpenAS = "Open as read-only";
        private const string pass = "Show Combination";
        private int sleepTimeShort = 500;
        private int sleepTimeNormal = 2000;
        private int sleepTimeLong = 3000;
        [TestMethod]
        public void SCEntry02_CheckBox01()
        {
            App = Application.Launch(appPath);
            Thread.Sleep(sleepTimeNormal);

            Window window = App.GetWindow(APP_TITLE);


            //   Button btnNew = window.Get<Button>(SearchCriteria.ByText("New..."));
            //   btnNew.Click();
            //   Button btnOK = window.Get<Button>(SearchCriteria.ByText("OK"));
            //   btnOK.Click();

            CheckBox check1 = window.Get<CheckBox>(pass);
            check1.Checked = true;
            //  check.State
            Assert.AreEqual(true, check1.Checked, "Asercja 02: Sprawdzenie czy CheckBox o nazwie (Show Combination) jest zaznaczony");
            // Assert.AreEqual(true, window.Items[4].Visible, "Asercja 03: Sprawdzenie czy pole jest widoczne dla uzytkownika");
            //    Assert.AreEqual(true, window.Items[3].Visible, "Asercja 04: Sprawdzenie czy okno jest widoczne po kliknieciu OK ");
            Thread.Sleep(sleepTimeShort);
            window.Close();
        }
        [TestMethod]
        public void SCEntry02_CheckBox02()
        {
            App = Application.Launch(appPath);
            Thread.Sleep(sleepTimeNormal);

            Window window = App.GetWindow(APP_TITLE);


            //   Button btnNew = window.Get<Button>(SearchCriteria.ByText("New..."));
            //   btnNew.Click();
            //   Button btnOK = window.Get<Button>(SearchCriteria.ByText("OK"));
            //   btnOK.Click();

            CheckBox check = window.Get<CheckBox>(OpenAS);
            check.Checked = true;
            //  check.State
            Assert.AreEqual(true, check.Checked, "Asercja 04: Sprawdzenie czy okno jest widoczne po kliknieciu OK ");
            Assert.AreEqual(true, window.Items[3].Visible, "Asercja 05: Sprawdzenie czy pole jest widoczne dla uzytkownika");

            // SearchCriteria searchCriteria1 = SearchCriteria.ByText("Open as read-only");
            //  CheckBox tbxIP = window.Get<CheckBox>(searchCriteria1);

            Assert.AreEqual(OpenAS, check.Text, "Asercja 09: Sprawdzenie tekstu opisujacego checkbox");

            Thread.Sleep(sleepTimeShort);
            window.Close();
        }
    }
    [TestClass]
    public class AutomatyzacjaTest3
    {
        private Application App;

        private readonly string appPath = @"C:\Program Files (x86)\Password Safe\pwsafe.exe";
        private const string path = "‪C:\\Users\\Adrian\\pwsafe.psafe3";
        private const string APP_TITLE = "Safe Combination Entry";
        //  private const string APP_TITLEBAR_ID = "TitleBar";
        private const string APP_VERSION = "V3.47.02";
        private const string ITEM_DEFAULT = "Default Settings";
        private const string ITEM_127_0_0_1 = "127.0.0.1";
        private const string OpenAS = "Open as read-only";
        private const string pass = "Show Combination";
        private int sleepTimeShort = 500;
        private int sleepTimeNormal = 2000;
        private int sleepTimeLong = 3000;
        [TestMethod]
        public void SCEntry03_ButtonCancel()
        {
            App = Application.Launch(appPath);
            Thread.Sleep(sleepTimeNormal);

            Window window = App.GetWindow(APP_TITLE);



            Button btnCancel = window.Get<Button>(SearchCriteria.ByText("Cancel"));
            btnCancel.Click();


            Assert.AreEqual(true, window.IsClosed, "Asercja 06: Sprawdzenie czy po kliknieciu cancel okno sie zamyka ");
            Thread.Sleep(sleepTimeShort);
            window.Close();


        }
        [TestMethod]
        public void SCEntry03_ButtonHelp()
        {
            App = Application.Launch(appPath);
            Thread.Sleep(sleepTimeNormal);

            Window window = App.GetWindow(APP_TITLE);




            Button btnHelp = window.Get<Button>(SearchCriteria.ByText("Help"));
            btnHelp.Click();



            Assert.AreEqual(false, window.IsClosed, "Asercja 07: Sprawdzenie czy okno jest widoczne po kliknieciu Help ");
            Thread.Sleep(sleepTimeShort);
            window.Close();
        }
        [TestMethod]
        public void SCEntry03_ButtonOK()
        {
            App = Application.Launch(appPath);
            Thread.Sleep(sleepTimeNormal);

            Window window = App.GetWindow(APP_TITLE);




            Button btnOK = window.Get<Button>(SearchCriteria.ByText("OK"));
            btnOK.Click();



            Assert.AreEqual(false, window.IsClosed, "Asercja 07: Sprawdzenie czy okno jest widoczne po kliknieciu Help ");
            Thread.Sleep(sleepTimeShort);
            window.Close();
        }
        [TestMethod]
        public void SCEntry03_ButtonNew()
        {
            App = Application.Launch(appPath);
            Thread.Sleep(sleepTimeNormal);

            Window window = App.GetWindow(APP_TITLE);




            Button btnNew = window.Get<Button>(SearchCriteria.ByText("New..."));
            btnNew.Click();



            Assert.AreEqual(false, window.IsClosed, "Asercja 07: Sprawdzenie czy okno jest widoczne po kliknieciu Help ");
            Thread.Sleep(sleepTimeShort);
            window.Close();
        }
        [TestMethod]
        public void SCEntry03_ButtonPath()
        {
            App = Application.Launch(appPath);
            Thread.Sleep(sleepTimeNormal);

            Window window = App.GetWindow(APP_TITLE);




            Button btnPath = window.Get<Button>(SearchCriteria.ByText("..."));
            btnPath.Click();



            Assert.AreEqual(false, window.IsClosed, "Asercja 07: Sprawdzenie czy okno jest widoczne po kliknieciu Help ");
            Thread.Sleep(sleepTimeShort);
            window.Close();
        }
        /*
            [TestMethod]
            public void PuttyConfigurationSessionTest06()
            {

                App = Application.Launch(appPath);
                Thread.Sleep(sleepTimeNormal);
                Window window = App.GetWindow(APP_TITLE);

                Thread.Sleep(sleepTimeShort);


                SearchCriteria searchCriteria1 = SearchCriteria.ByText("V3.47.02");
          //      TextBox tbxIP = window.Get<TextBox>(searchCriteria1);

                Assert.AreEqual(APP_VERSION, window, "Asercja 02: Sprawdzenie wpisania adresu IP");
                Thread.Sleep(sleepTimeShort);

                window.Close();
            }
            */
    }
}
