Salesforce sObject Data Dictionary Utility
------------------------------------------
### Why?

#### Once upon a time, I was required to produce a Data Dictionary for various Salesforce apps. After exploring the out-of-the-box options, that was just too much grunt work. Checked out some 3rd party AppExchange apps, they either cost too much for what they did or were shaky at best. 

**_Necessity is the Mother of Invention_**

So, why not put together a quick C# winform client app, gives me a chance to further explore the Salesforce API, and produce the raw materials(csv) for the required data dictionary documentation?

There are a number of things I would like to add when I get time, as it stands today it does what I need for my particular use case. May help others in the same or similar situation. As this is a work in progress, use at own risk.

#### Usage
1. Run exe
2. Provide Username, Password and Security Token for your Salesforce Instance
3. Click "Login and Retrieve sObjects", list view will populate
4. Check off sObjects you want to extract additional info about
  * Currently it is only getting sObject name, length, type and label
  * If it is a picklist it will generate a string containing all options instead of the label
  * If it is a reference, it will indicate which sObject it relates to instead of the label
5. Click "Generate Data Dictionary"
6. Give file a name and location, Save.

That's about it for now, if anything goes wrong, check the log.txt file in the directory the exe is running from for details.
