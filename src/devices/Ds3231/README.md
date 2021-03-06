# DS3231
DS3231 is a low-cost, extremely accurate I2C realtime clock (RTC) with an integrated temperature compensated crystal oscillator (TCXO) and crystal.

## Sensor Image
![](sensor.jpg)

## Usage
```C#
I2cConnectionSettings settings = new I2cConnectionSettings(1, Iot.Device.Ds3231.Ds3231.I2cAddress);
// get I2cDevice (in Linux)
UnixI2cDevice device = new UnixI2cDevice(settings);
// get I2cDevice (in Win10)
//Windows10I2cDevice device = new Windows10I2cDevice(settings);

using (Iot.Device.Ds3231.Ds3231 rtc = new Iot.Device.Ds3231.Ds3231(device))
{
    // set DS3231 time
    rtc.DateTime = DateTime.Now;
    // read time
    DateTime dt = rtc.DateTime;
    // read temperature
    double temp = rtc.Temperature;
}
```

## References
https://datasheets.maximintegrated.com/en/ds/DS3231.pdf
