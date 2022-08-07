using System;
using System.Collections.Generic;

namespace UserAgentGenerator
{
    public static class UserAgent
    {
        readonly static Random r = new Random();

        static string Chrome(Platform platform)
        {
            var webkitVersion = getRandomResource("ChromeWebkitVersion");
            var chromeVersion = getRandomResource("ChromeVersion");

            switch (platform)
            {
                case Platform.Desktop:
                    return $"Mozilla/5.0 ({getRandomResource("os")}) AppleWebKit/{ webkitVersion} (KHTML, like Gecko) Chrome/{chromeVersion} Safari/{ webkitVersion}";
                case Platform.Mobile:
                    return $"Mozilla/5.0 (Linux; Android {getRandomResource("AndroidVersion")}; {getRandomResource("Device")}) AppleWebKit/{webkitVersion} (KHTML, like Gecko) Chrome/{chromeVersion} Mobile Safari/{webkitVersion}";
            }

            return "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.93 Safari/537.36"; //for default
        }



        private static string getRandomResource(string resourceType)
        {

            var dict = new Dictionary<string, List<string>>{
                { "os", new List<string> {
                    "Windows NT 6.4",
                    "Windows NT 10.0; Win64; x64",
                    "Windows NT 6.3",
                    "Windows NT 6.1; Win64; x64",
                    "X11; Ubuntu",
                    "X11; Linux x86_64",
                    "Macintosh; Intel Mac OS X 10_11_0",
                    "Macintosh; Intel Mac OS X 10_12",
                    "Macintosh; Intel Mac OS X 10_13_3",
                    "Macintosh; Intel Mac OS X 10_13_4",
                    "Macintosh; Intel Mac OS X 10_13_6",
                    "Macintosh; Intel Mac OS X 10_15_2",
                    "Macintosh; Intel Mac OS X 10_15_6",
                    "Macintosh; Intel Mac OS X 10_15_7",
                    "Macintosh; Intel Mac OS X 10_14_6"

                }},
                { "ChromeWebkitVersion", new List<string> {
                    "528",
                    "530",
                    "532",
                    "532.5",
                    "49",
                    "533",
                    "534.3",
                    "534.10",
                    "534.13",
                    "534.16",
                    "534.24",
                    "534.30",
                    "535.1",
                    "535.2",
                    "535.7",
                    "537.17",
                    "537.22",
                    "537.36",
                    "605.1.15",
                    "789"
                }},
                { "ChromeVersion", new List<string> {
                    "92.0.4515.159",
                    "92.0.4515.131",
                    "91.0.4472.114",
                    "92.0.4515.107",
                    "85.0.4183.102",
                    "87.0.4280.88",
                    "87.0.4280.141",
                    "86.0.4240.198",
                    "89.0.4389.128",
                    "87.0.4280.144",
                    "86.0.4240.75",
                    "73.0.3683.86",
                    "64.0.3282.140"
                }},
                { "AndroidVersion", new List<string> {
                    "7.0",
                    "8.1.0",
                    "11",
                    "10",
                    "9",
                    "8.0.0"
                }},
                { "Device", new List<string> {
                    "RMX1911",
                    "Redmi 3 Build/QQ1D.200205.002",
                    "moto g power",
                    "IN2013",
                    "LM-V409N",
                    "ET1012T",
                    "CPH1989",
                    "BLA-L29",
                    "GM1911",
                    "ZE620KL",
                    "SAMSUNG SM-N960W",
                    "SM-G965U1",
                    "RNE-L21"
                }}
            };

            return dict[resourceType][r.Next(0, dict[resourceType].Count)];

        }


        public static string Generate(Browser browser, Platform platform)
        {
            string agent = "not found";
            switch (browser)
            {
                case Browser.Chrome:
                    agent = Chrome(platform);
                    break;
                default:
                    break;
            }

            return agent;
        }

    }
    public enum Platform
    {
        Desktop,
        Mobile
    }
    public enum Browser
    {
        Chrome
       // Firefox,
       //Safari,
       // IE,
       // Bot
    }
}
