//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XFP {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class HomePage : ContentPage {
        
        private Entry nombresEntry;
        
        private Entry apellidosEntry;
        
        private Entry salarioEntry;
        
        private DatePicker fechaContratoDatePicker;
        
        private Switch activoSwitch;
        
        private Button nuevoButton;
        
        private ListView datosListView;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(HomePage));
            nombresEntry = this.FindByName<Entry>("nombresEntry");
            apellidosEntry = this.FindByName<Entry>("apellidosEntry");
            salarioEntry = this.FindByName<Entry>("salarioEntry");
            fechaContratoDatePicker = this.FindByName<DatePicker>("fechaContratoDatePicker");
            activoSwitch = this.FindByName<Switch>("activoSwitch");
            nuevoButton = this.FindByName<Button>("nuevoButton");
            datosListView = this.FindByName<ListView>("datosListView");
        }
    }
}
