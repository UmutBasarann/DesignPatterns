using DesignPatterns.Template;

var transferMoneyTask = new TransferMoneyTask();
transferMoneyTask.Execute();

var generateReportTask = new GenerateReportTask();
generateReportTask.Execute();