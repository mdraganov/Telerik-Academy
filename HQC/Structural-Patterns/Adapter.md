# Structural Design Patterns 
## Adapter

### Кратко описание

Понякога в нов софтуерен проект искаме да използваме повторно вече съществуващ код, но това не е възможно, защото макар нашите класове да имат необходимата функционалност, но техните интерфейси са несъвместими. В такива случаи използваме Adapter.

Adapter, е софтуерна обвивка над съществуващи класове и интерфейси, която им дава възможност за по-нататъшна употреба. Използва се доста често и е лесен за имплементация.

В своето ежедневие ние използваме различни адаптери. Например не включваме директно в електрическата мрежа с 220 волта конзолата за игри, която се захранва с 9 волта. В този случай използваме адаптер, който да промени напрежението от 220 волта на 9 волта.

Адаптерът, за който ще говорим тук, работи на същия принцип, но с класове и обекти. Ако имаме клас, който предлага определени функции, но клиентът очаква някакъв друг интерфейс, тогава можем да сложим адаптер между тях. Ползата от адаптера е, че не е необходимо клиентският код да се променя всеки път, когато решите да сменим обекта, който се използва от клиента. Просто трябва да има адаптер написан за новия таргет и кодът на клиента ще работи безпроблемно.


### Имплементация

###### TradingDataImporter

	public class TradingDataImporter
    {
        public void ImportData(Connector connector)
        {
            connector.GetData();
        }
    }



###### Connector

    public abstract class Connector
    {
        public abstract void GetData();
    }
 
    public class DatabaseConnector : Connector
    {
        public override void GetData()
        {
            var databaseHelper = new DatabaseHelper();
            databaseHelper.QueryForChanges();
        }
    }
 
    public class XmlFileConnector : Connector
    {
        public override void GetData()
        {
            var xmlfileLoader = new XmlFileLoader();
            xmlfileLoader.LoadXML();
        }
    }
 
    public class HttpStreamConnector : Connector
    {
        public override void GetData()
        {
            var websiteScanner = new WebSiteScanner();
            websiteScanner.Scan();
        }
    }

###### DatabaseHelper

    public class DatabaseHelper
    {
        public void QueryForChanges()
        {
            Console.WriteLine("Database queried.");
        }
    }
 
    public class WebSiteScanner
    {
        public void Scan()
        {
            Console.WriteLine("Web sites scanned.");
        }
    }
 
    public class XmlFileLoader
    {
        public void LoadXML()
        {
            Console.WriteLine("Xml files loaded.");
        }
    }

###### Adapter
    
    public static void Adapter()
    {
        var tradingdataImporter = new TradingDataImporter();
 
        Connector databaseConnector = new DatabaseConnector();
        tradingdataImporter.ImportData(databaseConnector);
 
        Connector xmlfileConnector = new XmlFileConnector();
        tradingdataImporter.ImportData(xmlfileConnector);
 
        Connector httpstreamConnector = new HttpStreamConnector();
        tradingdataImporter.ImportData(httpstreamConnector);            
 
        Console.ReadKey();
    }

### UML Диаграма
![alt text](Pictures/Adapter.png)


