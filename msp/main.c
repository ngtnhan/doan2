#include <msp430g2553.h>
#include "Basic_config.h"
#include "UART.h"
#include<stdio.h>
#include<string.h>
#include<math.h>
unsigned int t;
unsigned char data[11];
unsigned int i=0;
int volthex;
 int checksum;
unsigned char send[11];

void decimal_hex(int n, char hex[]);

#define Vref 1.65
//#define Vref 1.5
unsigned long adc_result, volt;
int volt1;
void timer_init (void)
{
    TACTL = TASSEL_1 + MC_2;                  // ACLK (12kHz), continuous mode
    CCR0 = 12000;                            // cycle 12000*1/12000 = 1s
    CCTL0 = CCIE;                            // CCR0 interrupt enabled
}
void ADC10_Init(void)
{
    ADC10CTL0 = SREF_0 + ADC10SHT_1 + ADC10ON + ADC10IE;

//	ADC10CTL0=SREF_1+ ADC10SHT_0+ REFON + ADC10ON+ ADC10IE;
    /*
    * Vref = VCC
    * ADC sample and hold time = 8 ADC clocks
    * Turn on ADC10
    * Enable ADC10 Interrupt
    */
    ADC10CTL1 = INCH_3 + ADC10DIV_1 + ADC10SSEL_3;
//    ADC10CTL1 = INCH_3 + ADC10DIV_3;
    /*
    * Select Input chanel 3
    * ADC10DF = 0: The 10-bit conversion results are right justified
    * ADC10 Clock divider: 2
    * ADC10 clock source select: SMCLK
    */
    ADC10AE0 |= BIT3;    //Enable analog input on A3 chanel
}
void main(void)
{
    Config_stop_WDT();
    Config_Clocks();
    uart_init ();
    timer_init();
    ADC10_Init ();
    __enable_interrupt();
    _BIS_SR(GIE);
    P2DIR |= BIT3; //+BIT7;//6:cts-------7:rts
    //P2DIR &= ~BIT6;

    P2OUT |= BIT3; //+BIT7 ;
    ADC10CTL0 |= ENC + ADC10SC;    //Enable ADC10, Start sample - conversion
    delay_ms (200);
//


    send[0]=0x7E;
    send[1]=0x00;
    send[2]=0x07;
    send[3]=0x01;
    send[4]=0x01;
    send[5]=0x00;
    send[6]=0x01;
    send[7]=0x00;
    send[8]=0x31;
    send[9]=0xCB;

    while (1)
    {

    	volt1=volt;
    	checksum=203-volt1;


}}
#pragma vector = USCIAB0RX_VECTOR
__interrupt void USCI0RX_ISR(void)

{data[i]=uart_getc();
if (data[i]==0x7E)
{
	data[0]=0x7E;
	i=0;
}
i++;


	//    		data[0]=0x00;
	if (data[8]==0x31)
	{
		if (data[9]==0x31)
		{P2OUT &= ~BIT3;}
		if (data[9]==0x32)
		{P2OUT |= BIT3;}
	}




#pragma vector=TIMER0_A0_VECTOR
__interrupt void Timer_A (void)
{
	    volt = (adc_result * Vref*100 ) / 1024;    //Calculate result (= 100 * Voltage)
//    	if ((P2IN & BIT6)==0)
//
	    uart_putc(send[0]);
	    	uart_putc(send[1]);
	    	uart_putc(send[2]);
	    	uart_putc(send[3]);
	    	uart_putc(send[4]);
	    	uart_putc(send[5]);
	    	uart_putc(send[6]);
	    	uart_putc(send[7]);
	    	uart_putc(send[8]);
	       	uart_putc(volt1);
	    	uart_putc(checksum);
	    ADC10CTL0 |= ENC + ADC10SC;    //Enable ADC10, Start sample - conversion
	    CCR0 += 12000;                      // Add Offset to CCR0
}
// ADC10 interrupt service routine
#pragma vector = ADC10_VECTOR
__interrupt void ADC10_Interrupt(void)
{
    adc_result = ADC10MEM;                    //Save Result
}


