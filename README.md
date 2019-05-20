# 构建简单Windows Service示例

#### 1. 创建Windows Service项目，如图：

![](https://8y5i1a.dm.files.1drv.com/y4mx2AAJ6Uz5HpxT-L6DwXx9QEckll5S9-Xuh8Z-l4GmbjE8xOJLboUmRX5FTiOsZZItK2m3e9M5oqIq9ufuDJlgVa7dlRaOvQ-yuUAJ86CPavK2r5-BByqPpRARi9AbZe7EDQTPGTL4sz796KdnId3R_wzvFn2hsNWeRIkN6ILjBkq2_7FL5si_ddZ_Ni895SkD_GDHzm7zBHu5OkbRsl7yg?width=1278&height=860&cropmode=none)

#### 2. 配置服务参数

![](https://8y5dqq.dm.files.1drv.com/y4mQO58851eAeftdWf62TphAaYcwIhAslHnWYufmv97dE-ZZxf06UnCxfG1g42K75DgahqTOQGjere620pNU0ukZx86rYBwsGQ4geusPLfazKFxhmVjXQBwhiNOmTTFSlsfU3bu6PH4GL4TDYEIgZY-TQcds47yPHsF897jZvn5srqn4IMJiPBXrdpAw2PX4ST5s-_gITWAbi29pFrNE_k-zw?width=454&height=338&cropmode=none)

![](https://8y7cna.dm.files.1drv.com/y4mEknoLXq7Wa7BR6rMSJI09GYLD6LJZVdKBlOMfeOcF4Qz6XFL1pg_EgNYspu8DFAh7cECO6ZmB53x9WdDszy1O5Y-rfLcrDfYS-TFn_QPtjZ-TVcBpvB8w2dKDeJIBGcZeSpuFQmHzbCc1K-5BPYeFBiWG7xsB7jsUPAxBxN8T1K_WwPIezddFoS0xfafO8hrYCX3c-lkYT6byDK4t2OGVQ?width=463&height=416&cropmode=none)

#### 3. 安装，启动，停止，卸载服务

![](https://wuxfaw.dm.files.1drv.com/y4mAYyQew2VjS_gayeUWA6lIE3aE6VWTiEBagulQBk28DWRb6b1rkd3Dm1g9rFyNQgIu1ubJGKC0qhjEmy5HE8Q_KOYMvY66pyAgo7-qM9yFI0Jjr_9xfnMRu_e4mDZCpaJ3-hcZYXRuneWtyduRJdsqCtxUAmMdlqyOtW3OBT8jw7h5aP6dQWxAPL7Or6OU-KpshSfyw2i4oMN8yKtjMteBw?width=586&height=195&cropmode=none)

实现代码：

```c#
    private string ServicePath => txtServicePath.Text.Trim();
    private string ServiceName => "ServiceSample";
 
    private void BtnStart_Click(object sender, EventArgs e)
    {
        if (!ServiceHelper.IsExisted(ServiceName))
        {
            MessageBoxHelper.ShowError($"{ServiceName}不存在");
            return;
        }
 
        ServiceHelper.Start(ServiceName);
    }
 
    private void BtnStop_Click(object sender, EventArgs e)
    {
        if (!ServiceHelper.IsExisted(ServiceName))
        {
            MessageBoxHelper.ShowError($"{ServiceName}不存在");
            return;
        }
 
        ServiceHelper.Stop(ServiceName);
    }
 
    private void BtnInstall_Click(object sender, EventArgs e)
    {
        if (ServiceHelper.IsExisted(ServiceName))
        {
            MessageBoxHelper.ShowError($"{ServiceName}已经存在");
            return;
        }
 
        ServiceHelper.Install(ServicePath);
    }
 
    private void BtnUnInstall_Click(object sender, EventArgs e)
    {
        if (!ServiceHelper.IsExisted(ServiceName))
        {
            MessageBoxHelper.ShowError($"{ServiceName}不存在");
            return;
        }
 
        ServiceHelper.Uninstall(ServicePath);
    }
}
```

