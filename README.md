# UserAgentGenerator

## Why

As a software developer, I deal with a lot of crawling projects every day. This small pack helps me when I send HTTP requests with random user agents.

## How to use

Always start with using 

  ```cs
  using UserAgentGenerator;
  ```

User Agent Generator is easy to use. Select browser and platform then you are ready to go.

  ```cs
   var user-agent = UserAgent.Generate(Browser.Chrome, Platform.Desktop);
  ```
  