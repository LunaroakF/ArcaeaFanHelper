# ArcaeaFanHelper变速谱面的复制，再变速
Arcade 变速复制 使用其将Arcaea自制谱面变速部分复制到另一个时间段，变速谱面局部/全局变速  
或者用于超长段复制与变速。 适用于Arcade by Schwarzer

使用该程序将Arcaea自制谱面的变速部分复制到另一个时间段，或者用于调整整体时间以及复制粘贴   
  
最初目的是调整Timing，将Arcade的变速谱面复制粘贴与变速  
但现在可调整一堆东西  
  
或者将谱面全部/部分变速（v2.0更新）  
****  

## 程序图片  
![Image text](https://github.com/LunaroakF/Images/blob/master/ArcaeaFanHelper/2.2.jpg)  

## 作用  
你在写Arcaea自制谱的时候需要移动或者复制已经做好的一部分，需要修改谱面文档里的时间段，越多越麻烦，使用该软件可以让你将铺面的一部分迅速复制到另一个时间段。  
v2.0新功能：谱面变速  

若无需变速功能则在变速框输入1即可  

## 注意  
#### 整体
 - 数据转换时请将camera单独转换  
#### 变速  
 - 变速倍速请勿过于接近0 例如0.001  
 - 变速倍数请勿过大 例如9000000000  
 - 建议变速倍数小数部分在3位小数以内  
  

## 支持格式  
 - timing(1,2,3);    
 - hold(1,2,3);  
 - arc(1,2,3,4,5,6,7,8,9,10);  
 - arc(1,2,3,4,5,6,7,8,9,10)[arctap(1),arctap(2)......];  
 - (1,2);  
 - camera(1,2,3,4,5,6,7,8,9);  
  
(数字代表一个量)  
例如:  
****  
timing(5647,43.50,4096.00);  
hold(5650,5780,3);  
arc(5660,5678,1.25,0.81,b,0.20,0.30,0,none,true);  
arc(5690,5700,0.88,0.88,s,0.00,0.00,0,none,true)[arctap(5720),arctap(5722),arctap(5724)];  
(5730,2);  
****  
camera(0,0.00,-300.00,-6000.00,180.00,25.00,0.00,qo,1);  
camera(1,0.00,750.00,2125.00,90.00,-45.00,0.00,qi,1499);  
****  
以上为Arcaea自制谱部分文件内容  
使用该软件就把上面类似的数据复制到软件输入框(你的自制谱部分内容)  
输入开始时间  
按下转换即可开始龙王的工作~  
 - 还请注意将camera分开与其他数据处理比较好    
  
