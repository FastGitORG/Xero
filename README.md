# Xero

🔧 Tool to calculate Eff

## API Platform

- Dogyun
- None

## Mathematic Model

Since we are an anti generation service, the proportion of the rest of the traffic is very low, so we can assume that the inbound and outbound data are equal.

Statistics show that inbound traffic is much higher than outbound traffic. So we assume a situation where we have traffic bias due to request asynchronization. So we think it is more reasonable to treat the inbound station as a whole.

After that, we have the following formula to calculate our Eff(Effective flow rate).

![Eff formula](https://latex.codecogs.com/svg.latex?Eff=\frac{Outbound\%20Transfer}{Inbound\%20Transfer})

And average eff:

![Eff formula](https://latex.codecogs.com/svg.latex?\overline{Eff}=\frac{\sum_{n=0}^{Num_{last}-1}Eff_n}{Num_{last}})
