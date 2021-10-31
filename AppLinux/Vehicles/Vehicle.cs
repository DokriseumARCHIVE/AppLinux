namespace AppLinux.Vehicles
{
    public interface Vehicle
    {
        public void setPS(int ps);
        public void setBrand(string brand);
        public void setModel(string model);
        public void setDamageInPercent(int damage);
        public int getPS();
        public string getBrand();
        public string getModel();
        public int getDamageInPercent();
    }
}