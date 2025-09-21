# Screen Fade System

* Screen Fades for Unity Projects
* Unity minimum version: **6000.1**
* Current version: **1.0.0**
* License: **MIT**
* Dependencies:
    - [com.actioncode.awaitable-system : 1.0.0](https://github.com/HyagoOliveira/AwaitableSystem/tree/1.0.0)

## Summary

Fades the entire Game Screen using any [AbstractScreenFader](/Runtime/AbstractScreenFader.cs) implementation.

## How To Use

Create a prefab and attach a component implementing the [AbstractScreenFader](/Runtime/AbstractScreenFader.cs) on it.

You don't need to create your own implementation. This package already provides two implementation to use:

1. [AnimationScreenFader](/Runtime/AnimationScreenFader.cs): fades the screen in and out using a local ```Animation``` component. Use this option to fade using the legacy animation system, which is very performative.
2. [CanvasScreenFader](/Runtime/CanvasScreenFader.cs): fades the screen in and out using a local ```CanvasGroup``` component. Use this option when you want to fade the screen using an UI ```CanvasGroup``` component.

There are two prefabs created using those components at the [Prefabs](/Prefabs/) folder. You can use those prefabs or create new variants of them.

If those components do not meet your specifications, please feel free to create your own fade component and perhaps contribute to the package. :)

## Installation

### Using the Package Registry Server

Follow the instructions inside [here](https://cutt.ly/ukvj1c8) and the package **ActionCode-ScreenFadeSystem** 
will be available for you to install using the **Package Manager** windows.

### Using the Git URL

You will need a **Git client** installed on your computer with the Path variable already set. 

- Use the **Package Manager** "Add package from git URL..." feature and paste this URL: `https://github.com/HyagoOliveira/ScreenFadeSystem.git`

- You can also manually modify you `Packages/manifest.json` file and add this line inside `dependencies` attribute: 

```json
"com.actioncode.screen-fade-system":"https://github.com/HyagoOliveira/ScreenFadeSystem.git"
```

---

**Hyago Oliveira**

[GitHub](https://github.com/HyagoOliveira) -
[BitBucket](https://bitbucket.org/HyagoGow/) -
[LinkedIn](https://www.linkedin.com/in/hyago-oliveira/) -
<hyagogow@gmail.com>