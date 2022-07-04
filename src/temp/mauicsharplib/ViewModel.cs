namespace mauilib
{
    public class ViewModel : Prism.Mvvm.BindableBase
    {
        private int _id = 0;
        private string _name = "";
        private int _age = 0;
        private string _address = "";
        private string _result = "";

        public int Id
        {
            get { return _id; }
            set {  SetProperty(ref _id, value,nameof(Id)); }
        }
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value,nameof(Name)); }
        }
        public int Age
        {
            get { return _age; }
            set { SetProperty(ref _age, value,nameof(Age)); }
        }
        public string Address
        {
            get { return _address; }
            set {  SetProperty(ref _address, value,nameof(Address)); }
        }
        public string Result
        {
            get { return _result; }
            set {  SetProperty(ref _result, value,nameof(Result)); }
        }
    }
}