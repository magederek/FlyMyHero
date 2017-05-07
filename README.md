# 下载链接

好像不破解也是能用的，就是要注册一大堆帐号。。。

- [Unity winx64](http://netstorage.unity3d.com/unity/497a0f351392/Windows64EditorInstaller/UnitySetup64-5.6.0f3.exe)

- [unity winx64 破解补丁](https://raw.githubusercontent.com/magederek/FlyMyHero/master/Tools/UniPatcher.exe)


# 安装步骤

- 安装unity，一直下一步就可以了，记住他的安装目录，一般是
```
C:\Program Files\Unity
```

- 以管理员权限运行破解补丁，点击browse，选择unity安装目录下的editor权限，一般为
```
C:\Program Files\Unity\Editor
```

- 点击patch


# 下载游戏

- 简单方法（费时费力，每次更新了游戏都需要重新下载）：打开网址，[FlyMyHero](https://github.com/magederek/FlyMyHero) ，点击右边的**clone or download**，再点击**Download Zip**

- 复杂方法（快速更新）：学习git
 
	- 下载github客户端，不用安装，直接解压就能用，点[这里](https://pan.baidu.com/s/1gfh4m7T)下载。运行里边的Github.exe。

	- 注册github帐号
 	  登录客户端，刚开始会提示一些信息，不用理，一直continue或者skip就可以了

	- 点击右上方那个时而变形，再点```Open in git shell```

	- 然后输入命令```git clone https://github.com/magederek/FlyMyHero.git```，等待他下载完成。

	- 然后关掉git shell，点击Github客户端左上角的加号，选中Add，找到下载游戏的目录（如果不知道下到哪里的的话，可以点击十二边形->Open In Explorer，把路径粘贴过来，注意要选到游戏项目里边），然后点击Add Repository。

	- 等他配置好就行了，以后没事可以点一下右上方的sync，同步一下


# 运行游戏

- 打开unity，（解压）找到游戏代码

- 点击open，找到游戏目录，然后选择文件夹就可以了

- 点击```File->Open Scene```，打开Assets文件夹下面的FlyMyHero.unity文件

- 就看到我们的游戏场景了，看到中间两个选项卡scene和game，可以切换到game选项卡，然后点击上边的三角形，游戏就运行啦，再点一次游戏就停止了
