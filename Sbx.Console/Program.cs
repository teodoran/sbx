using Terminal.Gui;

Application.Init();
var top = Application.Top;

var win = new Window("SBX")
{
    X = 0,
    Y = 1,
    Width = Dim.Fill(),
    Height = Dim.Fill()
};

top.Add(win);

var menu =
    new MenuBar(
        new MenuBarItem[]
        {
            new MenuBarItem("_Quit", "", () => { top.Running = false; })
        });

top.Add(menu);

var welcome = new Label("Welcome to SBX") { X = 3, Y = 3 };
win.Add(welcome);

Application.Run();
Application.Shutdown();