using DesignPatterns.Command.Editor;

var history = new History();
var editor = new HtmlEditor();
editor.SetContent("Hello World");

var boldCommand = new BoldCommand(editor, history);
boldCommand.Execute();

Console.WriteLine(editor.GetContent());

var undoCommand = new UndoCommand(history);
undoCommand.Execute();

Console.WriteLine(editor.GetContent());