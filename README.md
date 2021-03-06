# ChanGenTool
信道建模与仿真软件
## 准备
* VS2010
* MATLAB R2013a x64
* [PCIEDriver](https://github.com/SigalHu/PCIEDriver)
## 实现功能
根据用户输入参数生成动态或静态信道，并通过PCIE将信道数据发送到底层设备
## 软件截图
![image](https://github.com/SigalHu/ChanGenTool/raw/master/img/动态衰落.png) ![image](https://github.com/SigalHu/ChanGenTool/raw/master/img/静态衰落.png)
## 版本更新
* v1.1.0 20170302 更新：
1. 新增静态衰落频谱形状：高斯I、高斯II
2. 新增静态衰落预定义信道模型相关代码

* v1.0.10 20170208 更新：
1. 静态衰落多普勒偏移可输入负数

* v1.0.10 20170111 更新：
1. 优化静态衰落控件变灰相关代码
2. 修复若干Bug

* v1.0.10 20170106 更新：
1. 修复动态衰落信道参数播放相关Bug
2. 新增动态衰落表格右键菜单
3. 新增选择文件拖入与动态衰落信道参数文件拖入
4. 新增拖入配置文件载入当前界面配置
5. 新增驱动控制相关代码

* v1.0.9 20170104 更新：
1. 在动态衰落中添加噪声模块
2. 修复若干Bug
3. 优化各子界面模块化

* v1.0.8 20161230 更新：
1. 修复若干Bug
3. 优化静态衰落多径衰落相关操作

* v1.0.8 20161229 更新：
1. 优化动态衰落地面特性相关操作

* v1.0.8 20161224 更新：
1. 添加驱动库，增加操作硬件FPGA相关代码
2. 新增硬件配置相关界面
3. 防止双击标题栏最大化

* v1.0.7 20161223 更新：
1. 增加动态衰落参数播放相关代码
2. 修改动态衰落参数表格设置

* v1.0.6 20161220 更新：
1. 修复Bug：将TabControlEx.TabIndex改为TabControlEx.SelectedIndex
2. 修复Bug：获取输出文件名中12小时制修改为24小时制
3. 优化Matlab调用相关代码
4. 增加调用Matlab动态衰落生成函数的相关代码
5. 优化配置文件载入
6. 去掉静态衰落的载波频率
7. 优化静态衰落表格相关代码
8. 增加调用Matlab静态衰落生成函数的相关代码

* v1.0.5 20161219 更新：
1. 将动态衰落的状态更新速率的0\~20ms输入限制修改为10\~1000ms，并且输入值必须为10的整倍数
2. 完善listGeneRice存储并改名为listGeneFad
3. 去掉静态衰落中的恒定相位衰落类型
4. 修复Bug：静态衰落中衰落类型由莱斯衰落改为其他类型时气泡提示显示错误
5. 在静态衰落的多径参数设置表格中新增列：多普勒偏移
6. 为静态衰落中的纯多普勒衰落类型添加弹出对话框
