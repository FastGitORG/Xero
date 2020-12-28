# Xero

🔧 Tool to calculate EFR

## What's EFR

***EFR***, also known as *Effective Flow Rate*, a value to envalue the rate of proxy server's effective traffic. **Higher is better.**

## API Platform

- Dogyun
- None

## Mathematics Model

Since FastGit is a reverse proxy service, the proportion of the rest of the traffic is very low, so we can assume that the inbound and outbound data are equal.

Statistics show that inbound traffic is much higher than outbound traffic. So we assume a situation where we have traffic bias due to request asynchronization. So we think it is more reasonable to perform inbound traffic as denominator.

After that, we have the following formula to calculate our EFR.

![EFR formula](https://latex.codecogs.com/svg.latex?\text{EFR}=\frac{N_\text{Outbound\\%20Transfer}}{N_\text{Inbound\\%20Transfer}})

And average EFR:

![EFR formula](https://latex.codecogs.com/svg.latex?\overline{\text{EFR}}=\frac{\sum_{n=0}^{N_{\text{last}}-1}\text{EFR}_n}{N_\text{last}})
