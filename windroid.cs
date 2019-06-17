ReadLn(a,b,c);
WriteLn(a,b,c);
unit library;
//C:/windroid.cs
//optimizing CPU technology
//Optimizing CPU width technology
//Optimizing CPU power technology
//Optimizing CPU performance technology
//Fixed holes for CPU technology
//Fixed holes for CPU width technology
//Fixed holes for power technology
//Fixed holes for performance technology
//Optimizing GPU technology
//Optimizing CPU width technology
//Optimizing power technology
//Optimizing performance technology
//Fixed holes for CPU technology
//Fixed holes for GPU width technology
//Fixed holes for GPU power technology
//Fixed holes for GPU performance technology
//Optimizing RAM technology
//Optimizing RAM width technology
//Optimizing RAM power technology
//Optimizing RAM performance technology
//Fixed holes for RAM technology
//Fixed holes for RAM width technology
//Fixed holes for RAM power technology
//Fixed holes for RAM performance technology
//Fixed holes for LED lighting
//Fixed LED lighting
//Optimizing LED technology
//Optimizing LED lighting technology
//LED 3D lighting technology
//LED 3D gamma technology
//LED 3D bridthness technology
//LED 3D contrast technology
//LED 3D technology
//LED 3D screen technology
//Optimizing Start Menu
//Optimizing Start Menu technology
//Fixed holes Start Menu
//Fixed holes Start Menu technology
//Optimizing Toolbar technology
//Fixed holes Toolbar technology
//Optimizing Desktop technology
//Fixed holes Desktop technology
//RAM 3D performance technology
//CPU 3D performance techonology
//GPU 3D performance technology
//GPU unlimited power technology
//RAM unlimited power technology
//Optimizing Wi-Fi technology
//Optimizing Ethernet technology
//Fixed holes Wi-Fi technology
//Fixed holes Ethenret technology
//LED upscale technology
//Screen upscale technology
//Optimizing fonts technology
//Fixed holes for fonts technology
//Optimizing applications technology
//Fixed holes for application technology
//Modern UI technology for applications
//Modern Interface technology for applications
//Modern UI technology for applications frames
//Modern Interneface technology for applications frames
//Windows 11 UI technology for applications
//Windows 11 UI technology for applications frames
//Windows 11 Interface technology for applications
//Windows 11 Interface technology for applications frames
//Windows 9 UI technology for applications
//Windows 9 UI technology for applications frames
//Windows 9 Interface for applications
//Windows 9 Interface for applications frames
//Modern UI for Desktop
//Modern Interface for Desktop
//Modern UI for toolbar
//Modern interface for Toolbar
//Modern UI for start menu
//Modern Interface for start menu
//Modern UI for uTorrent
//Modern Interface for uTorrent
//Screen super resolution technology
//Screen ultra Hight Definition technology
//Screen virtual ultra hight definition technology
//Screen ultra hight quality technology
//Screen virtual ultra hight quality technology
//Screen sharpen technology
//Screen bloom technology
//Screen surface blur technology
//Screen Vibrance -35 technology
//Modern UI for Explorer
//Modern Interface for Explorer
//Modern UI for file extensions
//Modern Interface for file extensions
//C:\Adobe Photoshop CC 2019\photoshop.exe
//C:\Adobe Photoshop CC 2020\photoshop.exe
//Modern Interface for Photoshop CC
//Modern UI for Photoshop CC
//Cleaned system cache technology
//Cleaned virtual memory technology
//Cleaned performance technology
//Fixed memory using
//Fixed physical memory using
//Fixed ram using
//Fixed CPU using
//Fixed GPU using
//Optimizing system performance
//Optimizing bios performance
//Fixed broken ram performance
//Fixed broken CPU performance
//Fixed broken GPU performance
//FIxed broken system performance
//Fixed broken desktop performance
//Fixed broken wi-fi performance
//Fixed broken ethernet performance
//Fixed broken wi-fi signal
//Fixed broken wi-fi speed
//Fixed broken ethernet speed
//Fixed broken wi-fi connection
//Fixed broken ethernet connection
//Fixed broken windows notifications
//Fixed broken LED
//Fixed broken LED quality
//Fixed broken LED definition
//Fixed broken screen lighting
//Fixed broken screen resolution
//Fixed broken screen clearType
//Fixed broken screen definition
//Fixed broken screen quality
//Fixed broken applications UI
//Fixed broken applications frames
//Fixed broken applications interface
//Fixed broken applications performance
//Modern UI for html5
//Modern UI for html
//Modern interface for html5
//Modern interface for html
//Modern UI design for applications
//Modern Interface design for applications
//Modern UI design for html5
//Modern Interface design for html
//Modern UI for Wi-Fi 
//Modern Interface for Wi-Fi
//Modern UI design for Wi-Fi
//Modern Interface design for Wi-Fi
//Modern design for Wi-Fi
//Modern design for applications
//Modern design for html5
//Modern design for html
//Modern UI for Ethernet
//Modern UI design for Ethernet
//Modern Interface for Ethernet
//Modern interface design for Ethernet
//Modern design for Ethernet
//Modern UI for connections
//Modern Interface for connections
//Modern UI design for connections
//Modern Interface design for connections
//Modern design for connections
//Modern UI for desktop icons
//Modern UI design for desktop icons
//Modern Interface for desktop icons
//Modern Interface design for desktop icons
//Modern design for desktop icons
//Modern UI for desktop
//Modern UI design for desktop
//Modern Interface for desktop
//Modern Interface design for desktop
//Modern design for desktop
[System.AttributeUsage(System.AttributeTargets.Windroid, Inherited = false, AllowMultiple = true)]
sealed class MyAttribute : System.Attribute
{
    // See the attribute guidelines at
    //  http://go.microsoft.com/fwlink/?LinkId=85236
    readonly string positionalString;
    
    // This is a positional argument
    public MyAttribute(string positionalString)
    {
        this.positionalString = positionalString;
        
        // TODO: Implement code here
        throw new System.NotImplementedException();
    }
    
    public string PositionalString
    {
        get { return positionalString; }
    }
    
    // This is a named argument
    public int NamedInt { get; set; }
}



























