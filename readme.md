# When using NUnit 3.7.1 the tests in this project fail with the below error message.
# If you switch NUnit to 3.6.1, the tests succeed.

	Test Name:	Multiply two numbers, Variant 0 in TwoTimesTables
	Test FullName:	Nunit371Issue.Tests.TwoTimesTables.#()::TestAssembly:Nunit371Issue.Tests/Feature:TwoTimesTables/Scenario:Multiply+two+numbers%2c+Variant+0
	Test Source:	C:\ExternalCode\Temp-NunitIssue\Nunit371Issue.Tests\SpecFlowFeature1.feature : line 14
	Test Outcome:	Failed
	Test Duration:	0:00:00.1551459
	
	Result1 Name:	Multiply two numbers, Variant 0
	Result1 Outcome:	Failed
	Result1 Duration:	0:00:00.1411407
	Result1 StackTrace:	
	System.NullReferenceException: Object reference not set to an instance of an object.
	at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression, String message, Object[] args)
	at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression)
	at Nunit371Issue.Tests.StepDefinitions.TwoTimesTablesSteps.ThenTheResultIsValid(Int32 calculated) in C:\Users\khatcher\documents\visual studio 2017\Projects\Nunit371Issue\Nunit371Issue.Tests\StepDefinitions\TwoTimesTablesSteps.cs:line 28
	at lambda_method(Closure , IContextManager , Int32 )
	at TechTalk.SpecFlow.Bindings.BindingInvoker.InvokeBinding(IBinding binding, IContextManager contextManager, Object[] arguments, ITestTracer testTracer, TimeSpan& duration)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStepMatch(BindingMatch match, Object[] arguments)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStep(StepInstance stepInstance)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.OnAfterLastStep()
	at TechTalk.SpecFlow.TestRunner.CollectScenarioErrors()
	at Nunit371Issue.Tests.TwoTimesTablesFeature.ScenarioCleanup()
	at Nunit371Issue.Tests.TwoTimesTablesFeature.MultiplyTwoNumbers(String lhs, String rhs, String calculated, String[] exampleTags) in C:\Users\khatcher\documents\visual studio 2017\Projects\Nunit371Issue\Nunit371Issue.Tests\SpecFlowFeature1.feature:line 10
	at Nunit371Issue.Tests.TwoTimesTablesFeature.MultiplyTwoNumbers_Variant0()
	at TechTalk.SpecRun.Framework.TaskExecutors.StaticOrInstanceMethodExecutor.ExecuteInternal(ITestThreadExecutionContext testThreadExecutionContext)
	at TechTalk.SpecRun.Framework.TaskExecutors.StaticOrInstanceMethodExecutor.Execute(ITestThreadExecutionContext testThreadExecutionContext)
	at TechTalk.SpecRun.Framework.TestAssemblyExecutor.ExecuteTestNodeTask(TestNode testNode, ITaskExecutor task, TraceEventType eventType)
	Result1 Message:	Object reference not set to an instance of an object.
	Result1 StandardOutput:	
	Given I have a mathy instance
	-> done: TwoTimesTablesSteps.GivenIHaveAMathyInstance() (0.0s)
	
	When I multiply the numbers '2' and '1'
	-> done: TwoTimesTablesSteps.WhenIMultiplyTheNumbersAnd(2, 1) (0.0s)
	
	Then The result is valid '2'
	-> error: Object reference not set to an instance of an object.
	Result1 StandardError:	
	Object reference not set to an instance of an object.System.NullReferenceException: Object reference not set to an instance of an object.
	at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression, String message, Object[] args)
	at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression)
	at Nunit371Issue.Tests.StepDefinitions.TwoTimesTablesSteps.ThenTheResultIsValid(Int32 calculated) in C:\Users\khatcher\documents\visual studio 2017\Projects\Nunit371Issue\Nunit371Issue.Tests\StepDefinitions\TwoTimesTablesSteps.cs:line 28
	at lambda_method(Closure , IContextManager , Int32 )
	at TechTalk.SpecFlow.Bindings.BindingInvoker.InvokeBinding(IBinding binding, IContextManager contextManager, Object[] arguments, ITestTracer testTracer, TimeSpan& duration)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStepMatch(BindingMatch match, Object[] arguments)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStep(StepInstance stepInstance)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.OnAfterLastStep()
	at TechTalk.SpecFlow.TestRunner.CollectScenarioErrors()
	at Nunit371Issue.Tests.TwoTimesTablesFeature.ScenarioCleanup()
	at Nunit371Issue.Tests.TwoTimesTablesFeature.MultiplyTwoNumbers(String lhs, String rhs, String calculated, String[] exampleTags) in C:\Users\khatcher\documents\visual studio 2017\Projects\Nunit371Issue\Nunit371Issue.Tests\SpecFlowFeature1.feature:line 10
	at Nunit371Issue.Tests.TwoTimesTablesFeature.MultiplyTwoNumbers_Variant0()
	at TechTalk.SpecRun.Framework.TaskExecutors.StaticOrInstanceMethodExecutor.ExecuteInternal(ITestThreadExecutionContext testThreadExecutionContext)
	at TechTalk.SpecRun.Framework.TaskExecutors.StaticOrInstanceMethodExecutor.Execute(ITestThreadExecutionContext testThreadExecutionContext)
	at TechTalk.SpecRun.Framework.TestAssemblyExecutor.ExecuteTestNodeTask(TestNode testNode, ITaskExecutor task, TraceEventType eventType)
	
	Result2 Name:	Multiply two numbers, Variant 0 retry #1
	Result2 Outcome:	Failed
	Result2 Duration:	0:00:00.0050018
	Result2 StackTrace:	
	System.NullReferenceException: Object reference not set to an instance of an object.
	at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression, String message, Object[] args)
	at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression)
	at Nunit371Issue.Tests.StepDefinitions.TwoTimesTablesSteps.ThenTheResultIsValid(Int32 calculated) in C:\Users\khatcher\documents\visual studio 2017\Projects\Nunit371Issue\Nunit371Issue.Tests\StepDefinitions\TwoTimesTablesSteps.cs:line 28
	at lambda_method(Closure , IContextManager , Int32 )
	at TechTalk.SpecFlow.Bindings.BindingInvoker.InvokeBinding(IBinding binding, IContextManager contextManager, Object[] arguments, ITestTracer testTracer, TimeSpan& duration)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStepMatch(BindingMatch match, Object[] arguments)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStep(StepInstance stepInstance)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.OnAfterLastStep()
	at TechTalk.SpecFlow.TestRunner.CollectScenarioErrors()
	at Nunit371Issue.Tests.TwoTimesTablesFeature.ScenarioCleanup()
	at Nunit371Issue.Tests.TwoTimesTablesFeature.MultiplyTwoNumbers(String lhs, String rhs, String calculated, String[] exampleTags) in C:\Users\khatcher\documents\visual studio 2017\Projects\Nunit371Issue\Nunit371Issue.Tests\SpecFlowFeature1.feature:line 10
	at Nunit371Issue.Tests.TwoTimesTablesFeature.MultiplyTwoNumbers_Variant0()
	at TechTalk.SpecRun.Framework.TaskExecutors.StaticOrInstanceMethodExecutor.ExecuteInternal(ITestThreadExecutionContext testThreadExecutionContext)
	at TechTalk.SpecRun.Framework.TaskExecutors.StaticOrInstanceMethodExecutor.Execute(ITestThreadExecutionContext testThreadExecutionContext)
	at TechTalk.SpecRun.Framework.TestAssemblyExecutor.ExecuteTestNodeTask(TestNode testNode, ITaskExecutor task, TraceEventType eventType)
	Result2 Message:	Object reference not set to an instance of an object.
	Result2 StandardOutput:	
	Given I have a mathy instance
	-> done: TwoTimesTablesSteps.GivenIHaveAMathyInstance() (0.0s)
	
	When I multiply the numbers '2' and '1'
	-> done: TwoTimesTablesSteps.WhenIMultiplyTheNumbersAnd(2, 1) (0.0s)
	
	Then The result is valid '2'
	-> error: Object reference not set to an instance of an object.
	Result2 StandardError:	
	Object reference not set to an instance of an object.System.NullReferenceException: Object reference not set to an instance of an object.
	at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression, String message, Object[] args)
	at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression)
	at Nunit371Issue.Tests.StepDefinitions.TwoTimesTablesSteps.ThenTheResultIsValid(Int32 calculated) in C:\Users\khatcher\documents\visual studio 2017\Projects\Nunit371Issue\Nunit371Issue.Tests\StepDefinitions\TwoTimesTablesSteps.cs:line 28
	at lambda_method(Closure , IContextManager , Int32 )
	at TechTalk.SpecFlow.Bindings.BindingInvoker.InvokeBinding(IBinding binding, IContextManager contextManager, Object[] arguments, ITestTracer testTracer, TimeSpan& duration)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStepMatch(BindingMatch match, Object[] arguments)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStep(StepInstance stepInstance)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.OnAfterLastStep()
	at TechTalk.SpecFlow.TestRunner.CollectScenarioErrors()
	at Nunit371Issue.Tests.TwoTimesTablesFeature.ScenarioCleanup()
	at Nunit371Issue.Tests.TwoTimesTablesFeature.MultiplyTwoNumbers(String lhs, String rhs, String calculated, String[] exampleTags) in C:\Users\khatcher\documents\visual studio 2017\Projects\Nunit371Issue\Nunit371Issue.Tests\SpecFlowFeature1.feature:line 10
	at Nunit371Issue.Tests.TwoTimesTablesFeature.MultiplyTwoNumbers_Variant0()
	at TechTalk.SpecRun.Framework.TaskExecutors.StaticOrInstanceMethodExecutor.ExecuteInternal(ITestThreadExecutionContext testThreadExecutionContext)
	at TechTalk.SpecRun.Framework.TaskExecutors.StaticOrInstanceMethodExecutor.Execute(ITestThreadExecutionContext testThreadExecutionContext)
	at TechTalk.SpecRun.Framework.TestAssemblyExecutor.ExecuteTestNodeTask(TestNode testNode, ITaskExecutor task, TraceEventType eventType)
	
	Result3 Name:	Multiply two numbers, Variant 0 retry #2
	Result3 Outcome:	Failed
	Result3 Duration:	0:00:00.0090034
	Result3 StackTrace:	
	System.NullReferenceException: Object reference not set to an instance of an object.
	at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression, String message, Object[] args)
	at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression)
	at Nunit371Issue.Tests.StepDefinitions.TwoTimesTablesSteps.ThenTheResultIsValid(Int32 calculated) in C:\Users\khatcher\documents\visual studio 2017\Projects\Nunit371Issue\Nunit371Issue.Tests\StepDefinitions\TwoTimesTablesSteps.cs:line 28
	at lambda_method(Closure , IContextManager , Int32 )
	at TechTalk.SpecFlow.Bindings.BindingInvoker.InvokeBinding(IBinding binding, IContextManager contextManager, Object[] arguments, ITestTracer testTracer, TimeSpan& duration)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStepMatch(BindingMatch match, Object[] arguments)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStep(StepInstance stepInstance)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.OnAfterLastStep()
	at TechTalk.SpecFlow.TestRunner.CollectScenarioErrors()
	at Nunit371Issue.Tests.TwoTimesTablesFeature.ScenarioCleanup()
	at Nunit371Issue.Tests.TwoTimesTablesFeature.MultiplyTwoNumbers(String lhs, String rhs, String calculated, String[] exampleTags) in C:\Users\khatcher\documents\visual studio 2017\Projects\Nunit371Issue\Nunit371Issue.Tests\SpecFlowFeature1.feature:line 10
	at Nunit371Issue.Tests.TwoTimesTablesFeature.MultiplyTwoNumbers_Variant0()
	at TechTalk.SpecRun.Framework.TaskExecutors.StaticOrInstanceMethodExecutor.ExecuteInternal(ITestThreadExecutionContext testThreadExecutionContext)
	at TechTalk.SpecRun.Framework.TaskExecutors.StaticOrInstanceMethodExecutor.Execute(ITestThreadExecutionContext testThreadExecutionContext)
	at TechTalk.SpecRun.Framework.TestAssemblyExecutor.ExecuteTestNodeTask(TestNode testNode, ITaskExecutor task, TraceEventType eventType)
	Result3 Message:	Object reference not set to an instance of an object.
	Result3 StandardOutput:	
	Given I have a mathy instance
	-> done: TwoTimesTablesSteps.GivenIHaveAMathyInstance() (0.0s)
	
	When I multiply the numbers '2' and '1'
	-> done: TwoTimesTablesSteps.WhenIMultiplyTheNumbersAnd(2, 1) (0.0s)
	
	Then The result is valid '2'
	-> error: Object reference not set to an instance of an object.
	Result3 StandardError:	
	Object reference not set to an instance of an object.System.NullReferenceException: Object reference not set to an instance of an object.
	at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression, String message, Object[] args)
	at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression)
	at Nunit371Issue.Tests.StepDefinitions.TwoTimesTablesSteps.ThenTheResultIsValid(Int32 calculated) in C:\Users\khatcher\documents\visual studio 2017\Projects\Nunit371Issue\Nunit371Issue.Tests\StepDefinitions\TwoTimesTablesSteps.cs:line 28
	at lambda_method(Closure , IContextManager , Int32 )
	at TechTalk.SpecFlow.Bindings.BindingInvoker.InvokeBinding(IBinding binding, IContextManager contextManager, Object[] arguments, ITestTracer testTracer, TimeSpan& duration)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStepMatch(BindingMatch match, Object[] arguments)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.ExecuteStep(StepInstance stepInstance)
	at TechTalk.SpecFlow.Infrastructure.TestExecutionEngine.OnAfterLastStep()
	at TechTalk.SpecFlow.TestRunner.CollectScenarioErrors()
	at Nunit371Issue.Tests.TwoTimesTablesFeature.ScenarioCleanup()
	at Nunit371Issue.Tests.TwoTimesTablesFeature.MultiplyTwoNumbers(String lhs, String rhs, String calculated, String[] exampleTags) in C:\Users\khatcher\documents\visual studio 2017\Projects\Nunit371Issue\Nunit371Issue.Tests\SpecFlowFeature1.feature:line 10
	at Nunit371Issue.Tests.TwoTimesTablesFeature.MultiplyTwoNumbers_Variant0()
	at TechTalk.SpecRun.Framework.TaskExecutors.StaticOrInstanceMethodExecutor.ExecuteInternal(ITestThreadExecutionContext testThreadExecutionContext)
	at TechTalk.SpecRun.Framework.TaskExecutors.StaticOrInstanceMethodExecutor.Execute(ITestThreadExecutionContext testThreadExecutionContext)
	at TechTalk.SpecRun.Framework.TestAssemblyExecutor.ExecuteTestNodeTask(TestNode testNode, ITaskExecutor task, TraceEventType eventType)

