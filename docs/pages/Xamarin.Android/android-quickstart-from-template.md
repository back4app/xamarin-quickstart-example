---
layout: android
area: "Android"
title: "Quickstart from Template"
description: "Connect an Android Studio project template to your Back4App."
keywords: "android; quickstart; template"
prevTitle: "Creating New App"
prevUrl: "/docs/pages/back4app/creating-new-app"
nextTitle: "Custom SDK Installation"
nextUrl: "/docs/pages/android/how-to-build-an-android-app-on-back4app"
---
## {{page.title}} {#quickstart}



### Introduction {#introduction}

In this section you learn how to get started with an Android Studio template and get ready to use Back4App in 3 easy steps.

> If you want a detailed Quickstart guide or connect Back4App to an existing project, go to our [Custom SDK Installation Tutorial]({{site.baseurl}}/pages/android/how-to-build-an-android-app-on-back4app "Custom SDK Installation Tutorial")
{: .blockquote-tip}



### Prerequisites {#prerequisites}

> **To complete this quickstart, you need:**
> * Android Studio.
> * An app created at Back4App.
>   * Follow the [Creating New App tutorial]({{site.baseurl}}/pages/back4app/creating-new-app "Creating New App Tutorial") to learn how to create an app at Back4App.
{: .blockquote-tip}



### Step 1 - Get the template {#get-the-template}

Download the template at
[Back4App's GitHub repository](https://github.com/back4app/android-quickstart-example/archive/master.zip "Back4App's GitHub repository"){:target="_blank" rel="nofollow"}, and unzip files in your project folder.

You can do that using the following command line:
  ~~~ plain
  $ curl -LOk https://github.com/back4app/android-quickstart-example/archive/master.zip && unzip master.zip
  ~~~



### Step 2 - Open the project template {#open}

1. Open Android Studio.
1. Click on `Open an existing Android Studio project`.
  ![Android Studio Welcome Screen](/docs/assets/images/png/android_studio_welcome_screen.png){:class="img-fluid mt-3 mb-5 rounded shadowed"}
1. Navigate to the project folder and click on `OK`.
  ![Android Studio Opening file](/docs/assets/images/png/android_studio_open_file.png){:class="img-fluid mt-3 mb-5 rounded shadowed"}
1. Wait for Android Studio to open and run Gradle.



### Step 3 - Setup app's credentials {#setup}

Update your strings values to set up the app's credentials. Parse Android SDK uses these settings to connect to the Back4App servers.

1. Open your strings file: `.../app/src/main/res/values/strings.xml`
    ![Strings.xml File](/docs/assets/images/png/android_studio_strings_file.png){:class="img-fluid mt-3 mb-5 rounded shadowed"}
1. Go to your App Dashboard at Back4App website.
1. Navigate to app’s settings: Click on `Features` > `Core Settings` block > `Server`.
1. Return to your `strings.xml` file and paste your `applicationId` and `clientKey`.

> See more at our [Back4App's Creating New App guide]({{site.baseurl}}/pages/back4app/creating-new-app#creating-new-app-find-your-appid).
{: .blockquote-tip}



### Step 4 - Testing your connection {#testing-your-connection}

1. Build your app in a device or virtual device (`Shift`+`F10`).
    ![Build app](/docs/assets/images/png/android_studio_build_app.png){:class="img-fluid mt-3 mb-5 rounded shadowed"}
1. Wait until the `Hello Word!` screen appears.
1. Login at [Back4App](http://www.back4app.com).
1. Find your app and click on `Dashboard`.
1. Click on `Core`.
1. Go to `Browser`.


If everything works properly, you should find a class named `Installation` as follows:
![Installation at Back4App Dashboard](/docs/assets/images/png/back4app_parse_dashboard_installation.png){:class="img-fluid mt-3 mb-5 rounded shadowed"}

<!-- > When creating new activities, remember to initialize Parse by adding the following code snippet inside its `onCreate` method.
> <sub>[`MainActivity.java`](https://github.com/back4app/android-quickstart-example/blob/master/app/src/main/java/com/back4app/quickstartexampleapp/MainActivity.java#L17){:target="_blank" rel="nofollow"}</sub>
> ~~~java
> Parse.initialize(this);
> ~~~
{: .blockquote-note}

RETIREI ESSE WARNING TEMPORARIAMENTE ENQUANTO NÃO TENHO CERTEZA DA INFORMAÇÃO, IREI TESTAR COM O APP DO USER REGISTRATION -->



### Next Steps {#nextsteps}

At this point, you have learned how to get started with Android apps. You are now ready to explore [Parse Server core features](https://www.back4app.com/product/parse-server) and [Back4App add-ons](https://www.back4app.com/product/addons).

Learn more by walking around our [Android Tutorials](https://docs.back4app.com/docs/android/) or check [Parse open source documentation for Android SDK](http://docs.parseplatform.org/android/guide/){:target="_blank" rel="nofollow"}.
