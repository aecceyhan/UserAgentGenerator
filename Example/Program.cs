using System;
using UserAgentGenerator;


Console.WriteLine($"This is example user agent : {UserAgent.Generate(Browser.Chrome,Platform.Desktop)}");