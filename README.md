# Observer

Recruitment task for Sofrware Mind

## Installation

The entire application and its tests are based on .Net 5.0.
Throughout the creative period, I used Visual Studio 2019 and I propose to open this project on it.
A test reference to the project should be created automatically.

## Usage

The whole project is based on the idea of ​​getting groups of packages to be sorted at once. Immediately after turning on the application (after a few seconds), we should be greeted with the following result:

```
-------- packet received --------
1657241277: 1
1657241278: 0
1657241279: 0
1657241280: 1
1657241281: 1
1657241282: 0
1657241283: 1
1657241284: 1
-------- packet formatted --------
1657241277: 1
1657241278: 0
1657241280: 1
1657241282: 0
1657241283: 1
```
To change the time each packet appears, we need to go to DeviceService and change the values ​​to larger in Task.Delay (they are initially set to between 1000 and 1100 ms).
The result will repeat indefinitely, it simulates receiving data from the "device" and then redirecting it further to the microservice, where it will receive its already formatted form.
Although I know that it was only supposed to format the received data, but the task interested me enough that I started to "micro" simulate the whole problem :)

Thank you for your attention and have a nice day!
