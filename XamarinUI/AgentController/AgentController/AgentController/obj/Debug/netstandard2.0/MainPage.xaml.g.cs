//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("AgentController.MainPage.xaml", "MainPage.xaml", typeof(global::AgentController.MainPage))]

namespace AgentController {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("MainPage.xaml")]
    public partial class MainPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Lottie.Forms.AnimationView loading;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.PancakeView.PancakeView controllerCard;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.PancakeView.PancakeView agentCard;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(MainPage));
            loading = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Lottie.Forms.AnimationView>(this, "loading");
            controllerCard = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.PancakeView.PancakeView>(this, "controllerCard");
            agentCard = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.PancakeView.PancakeView>(this, "agentCard");
        }
    }
}
