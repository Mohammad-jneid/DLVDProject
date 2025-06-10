[1mdiff --git a/DLVDProject/DLVDProject.csproj b/DLVDProject/DLVDProject.csproj[m
[1mindex a4b1b9a..a1c8f39 100644[m
[1m--- a/DLVDProject/DLVDProject.csproj[m
[1m+++ b/DLVDProject/DLVDProject.csproj[m
[36m@@ -12,6 +12,21 @@[m
     <FileAlignment>512</FileAlignment>[m
     <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>[m
     <Deterministic>true</Deterministic>[m
[32m+[m[32m    <PublishUrl>publish\</PublishUrl>[m
[32m+[m[32m    <Install>true</Install>[m
[32m+[m[32m    <InstallFrom>Disk</InstallFrom>[m
[32m+[m[32m    <UpdateEnabled>false</UpdateEnabled>[m
[32m+[m[32m    <UpdateMode>Foreground</UpdateMode>[m
[32m+[m[32m    <UpdateInterval>7</UpdateInterval>[m
[32m+[m[32m    <UpdateIntervalUnits>Days</UpdateIntervalUnits>[m
[32m+[m[32m    <UpdatePeriodically>false</UpdatePeriodically>[m
[32m+[m[32m    <UpdateRequired>false</UpdateRequired>[m
[32m+[m[32m    <MapFileExtensions>true</MapFileExtensions>[m
[32m+[m[32m    <ApplicationRevision>0</ApplicationRevision>[m
[32m+[m[32m    <ApplicationVersion>1.0.0.%2a</ApplicationVersion>[m
[32m+[m[32m    <IsWebBootstrapper>false</IsWebBootstrapper>[m
[32m+[m[32m    <UseApplicationTrust>false</UseApplicationTrust>[m
[32m+[m[32m    <BootstrapperEnabled>true</BootstrapperEnabled>[m
   </PropertyGroup>[m
   <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">[m
     <PlatformTarget>AnyCPU</PlatformTarget>[m
[36m@@ -257,5 +272,17 @@[m
     <None Include="Icons\Icons\user %281%29.png" />[m
     <Content Include="LoginInfo.txt" />[m
   </ItemGroup>[m
[32m+[m[32m  <ItemGroup>[m
[32m+[m[32m    <BootstrapperPackage Include=".NETFramework,Version=v4.7.2">[m
[32m+[m[32m      <Visible>False</Visible>[m
[32m+[m[32m      <ProductName>Microsoft .NET Framework 4.7.2 %28x86 and x64%29</ProductName>[m
[32m+[m[32m      <Install>true</Install>[m
[32m+[m[32m    </BootstrapperPackage>[m
[32m+[m[32m    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">[m
[32m+[m[32m      <Visible>False</Visible>[m
[32m+[m[32m      <ProductName>.NET Framework 3.5 SP1</ProductName>[m
[32m+[m[32m      <Install>false</Install>[m
[32m+[m[32m    </BootstrapperPackage>[m
[32m+[m[32m  </ItemGroup>[m
   <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />[m
 </Project>[m
\ No newline at end of file[m
[1mdiff --git a/DLVDProject/frmEditApplicationsTypes.cs b/DLVDProject/frmEditApplicationsTypes.cs[m
[1mindex 5a1a6ff..b4989fc 100644[m
[1m--- a/DLVDProject/frmEditApplicationsTypes.cs[m
[1m+++ b/DLVDProject/frmEditApplicationsTypes.cs[m
[36m@@ -5,14 +5,14 @@[m [musing System.Data;[m
 using System.Drawing;[m
 using System.Linq;[m
 using System.Text;[m
[31m-using System.Threading.Tasks;[m
[32m+[m[32musing System.Threading.Tasks;[m[41m   [m
 using System.Windows.Forms;[m
 [m
 namespace DLVDProject[m
 {[m
[31m-    public partial class frmEditApplicationsTypes : Form[m
[32m+[m[32m    public partial class frmEditApplicationsTypes : Form[m[41m   [m
     {[m
[31m-        int _ApplicationTypeID;[m
[32m+[m[32m        int _ApplicationTypeID;[m[41m [m
         public frmEditApplicationsTypes(int ApplicationTypeID)[m
         {[m
             InitializeComponent();[m
