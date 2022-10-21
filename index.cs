// AUTHOR: DANIEL BARNARD
// Tracker
// Create program to track a device through the use of gps

// The GSM Unit contains a SIM card, It will sends GPS data in 2 modes, one is by SMS and other one is by using GPRS data.
// Before use the GPS Device, we need to configure it. Each device has its own configuration settings and methods, so choose a device and follow the configuration that the device manufacturer provides with user manual.

// By using GPRS, GPS Device will sends location information to a remote server, before that we need to set the remote server's IP address and PORT in the GPS device.
// Once the GPS Device is configured, it starts to send location information to the remote server as TCP packets. The remote server must be publicly accessible.

// Now, In the server side, we need to develop a TCP server in C# that have to listen to the PORT specified in the GPS Device.
// By using this server program, you can process the received data and you can show it on the map using Map APIs.

// Device: Samsung A32
// Utility: 