﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.1.84
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.296
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AkzeptanzTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.1.84")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Scorecard anzeigen")]
    public partial class ScorecardAnzeigenFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ScorecardAnzeige.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("de-DE"), "Scorecard anzeigen", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Scorecard anzeigen")]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void ScorecardAnzeigen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scorecard anzeigen", new string[] {
                        "ignore"});
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Loch",
                        "Schlaege"});
            table1.AddRow(new string[] {
                        "1",
                        "5"});
            table1.AddRow(new string[] {
                        "2",
                        "7"});
            table1.AddRow(new string[] {
                        "3",
                        "15"});
#line 4
 testRunner.When("ich folgendermassen spiele:", ((string)(null)), table1, "Wenn ");
#line 9
 testRunner.Then("erhalte ich diese Scorcard.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dann ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion