# [![NuGet version](https://badge.fury.io/nu/HDFCommAgent.NET.png)](https://badge.fury.io/nu/HDFCommAgent.NET)  HDFCommAgent.NET
- SI증권 OpenApi C# wrapper class
- 개발환경: Visual Studio 2022, netstandard2.0

---------------

```c#
using HDFCommAgent.NET;
...
    // 메인 윈도우 클래스 멤버로 선언
    private readonly AxHDFCommAgent api;

    public ctor()
    {
        // nint Handle = new WindowInteropHelper(Application.Current.MainWindow).EnsureHandle(); // WPF 에서만 필요
        api = new (Handle);

        // 이벤트 핸들러 등록
        api.OnGetMsg += Api_OnGetMsg;
        ...

    }

    private void Api_OnGetMsg(object sender, _DHDFCommAgentEvents_OnGetMsgEvent e)
    {
        ...
    }


```
