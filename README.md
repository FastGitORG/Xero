# Xero

🔧 Tool to calculate EFR

## API Platform

- Dogyun
- None

## Mathematic Model

Since we are a reserved proxy service, the proportion of the rest of the traffic is very low, so we can assume that the inbound and outbound data are equal.

Statistics show that inbound traffic is much higher than outbound traffic. So we assume a situation where we have traffic bias due to request asynchronization. So we think it is more reasonable to perform inbound traffic as denominator.

After that, we have the following formula to calculate our EFR(Effective Flow Rate).

![EFR formula](https://latex.codecogs.com/svg.latex?\text{EFR}=\frac{\text{Outbound\\%20Transfer}}{\text{Inbound\\%20Transfer}})

And average eff:

![EFR formula](https://latex.codecogs.com/svg.latex?\overline{\text{EFR}}=\frac{\sum_{n=0}^{Num_{last}-1}\text{EFR}_n}{Num_{last}})
