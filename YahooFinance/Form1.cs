using System;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;


namespace YahooFinance
{
    public partial class YahooFinanceParser : Form
    {
        public YahooFinanceParser()
        {
            InitializeComponent();

            if (string.IsNullOrWhiteSpace(textBox_input.Text))
            {
                button_ok.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string symbol = textBox_input.Text;
                string url = $"https://query1.finance.yahoo.com/v8/finance/chart/{symbol}?interval=1d";
                string json;
                using (WebClient wc = new WebClient())
                {
                    json = wc.DownloadString(url);
                }
                JObject data = JObject.Parse(json);

                
                JToken metaData = data["chart"]["result"][0]["meta"];
                string exchangeName = (string)metaData["exchangeName"];
                string instrumentType = (string)metaData["instrumentType"];
                long firstTradeDate = (long)metaData["firstTradeDate"];
                long regularMarketTime = (long)metaData["regularMarketTime"];
                long gmtoffset = (long)metaData["gmtoffset"];
                string timezone = (string)metaData["timezone"];
                string currency = (string)metaData["currency"];

                
                JArray timeSeries = (JArray)data["chart"]["result"][0]["timestamp"];
                JArray closePrices = (JArray)data["chart"]["result"][0]["indicators"]["quote"][0]["close"];

                
                string message = "Символ: " + symbol + "\n" +
                    "Название биржи: " + exchangeName + "\n" +
                    "Тип инструмента: " + instrumentType + "\n" +
                    "Первый день торгов: " + new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(firstTradeDate).ToLocalTime().ToString("dd/MM/yyyy") + "\n" +
                    "Обычное время на рынке: " + new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(regularMarketTime).ToLocalTime().ToString("dd/MM/yyyy hh:mm tt") + "\n" +
                    "Смещение времени по Гринвичу: " + TimeSpan.FromSeconds(gmtoffset).ToString(@"hh\:mm") + "\n" +
                    "Часовой пояс: " + timezone + "\n" +
                    "Валюта: " + currency;
                    message += "\nВремя и стоимость на закрытии\n";
                    DateTime prevDay = new DateTime();
                    for (int i = 0; i < timeSeries.Count; i++)
                    {
                        DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                        dateTime = dateTime.AddSeconds((long)timeSeries[i]).ToLocalTime();
                        message += dateTime.ToString("dd/MM/yyyy") + ", " + Math.Round((double)closePrices[i], 2) + "\n";
                    }
                MessageBox.Show(message, "Информация об акции");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введенной вами ценной бумаги не существует :(");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_input.Text))
            {
                button_ok.Enabled = false;
            }
            else
            {
                button_ok.Enabled = true;
            }
        }
    }
}