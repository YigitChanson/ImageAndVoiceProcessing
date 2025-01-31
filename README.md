
⚠️⚠️⚠️ YOU WILL FILL THE API KEYS IN THE CODES ACCORDING TO YOURSELF ⚠️⚠️⚠️
    Otherwise you can only use image processing

❗️❗️❗️ May contain unused/unnecessary NuGet packages because some erroneous commands have been removed

How You Fill the API Keys:

    You can go to Azure Portal (https://portal.azure.com) and create a new Azure Machine Learning source. 
    Once you have created it correctly, you must enter the information of this resource and click on “Manage Keys”. After showing the keys, you can use either KEY1 or KEY2. 
In var config = SpeechConfig.FromSubscription(“_AnotherKey_”, “_REGION_”) you need to copy one of the keys to the first part and the information from the Location/Region part to the region part. You have completed the first step. 



NuGet packages used for Image Processing:

    -Emgu.CV
    -Emgu.CV.Bitmap
    -Emgu.CV.Models
    -Emgu.CV.runtime.windows (or whatever you are using)

NuGet packages used for Voice Processing:

    -Microsoft.CognitiveServices.Speech
    -Newtonsoft.Json
    -RestSharp
    -Selenium.WebDriver



