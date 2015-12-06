# RayeUI

##설명
RayeUI는 WPF UI Framework입니다.
**깔끔한 디자인**이 특징으로 아무나 사용하실 수 있습니다.

##사용법
###RayeWindow
![RayeWindow](http://i.imgur.com/9PntuNz.png)

####기본 설정
1. Theme폴더와 Control폴더를 자신의 프로젝트에 복사합니다.
2. App.xaml에 Generic.xaml과 ControlDictionary.xaml을 ResourceDictionary로 추가합니다.
3. 사용할 윈도우에서 Window를 RayeWindow로 변경합니다. *(xaml과 cs 둘 다 적용해야함)*

####윈도우 아이콘 설정
설정 할 수 있는 아이콘은 윈도우 상단에 나타나는 아이콘(WindowIcon)과 작업 표시줄에 나타나는 아이콘(Icon)으로 구분됩니다.
WindowIcon에는 아래와같이 UIElement를 설정해 줄 수 있습니다.
```xaml
<control:RayeWindow.WindowIcon>
        <Path Width="20" Height="20" Stretch="Fill" Fill="#FF000000" Data="F1 M 27.9586,38.6386L 24,34.8214L 24,42.3333L 27.9586,38.6386 Z M 19,30L 25,28L 32.7021,34.2114L 49,19L 56,24L 56,53L 47,57L 32.5427,43.0591L 24,50L 19,47L 19,30 Z M 38.0872,38.5542L 47,45.742L 47,31.3125L 38.0872,38.5542 Z "/>
</control:RayeWindow.WindowIcon>
```

####윈도우 콘텐츠 설정
상단에 남는 자리를 채워줄 수 있습니다.

![WindowContent](http://i.imgur.com/MuBmdb3.png)

```xaml
    <control:RayeWindow.WindowContent>
        <Grid HorizontalAlignment="Right">
            <Button Content="설정" Style="{StaticResource WindowButtonStyle}" Width="100" Background="White" />
        </Grid>
    </control:RayeWindow.WindowContent>
```


###BorderlessWindow
![BorderlessWindow](http://i.imgur.com/OHVbSAA.png)

####기본 설정
RayeWindow와 설정 방법은 동일합니다.

####설정
BorderlessWindow는 사용자가 직접 꾸밀수있도록 여러 **설정**을 제공합니다.

1. CaptionHeight를 설정해 윈도우에 타이틀 영역을 설정 할 수 있습니다.
2. ResizeBorderThickness를 설정해 윈도우 주변에 리사이즈 할 수 있는 드래그 영역을 설정할 수 있습니다.
3. GlassFrameThickness를 설정해서 표준 윈도우를 보여줄 수 있습니다. [(참고)](https://msdn.microsoft.com/ko-kr/library/system.windows.shell.windowchrome.glassframethickness(v=vs.110).aspx)

###RayeButton
![RayeButton1](http://i.imgur.com/CPYh1zU.gif)
![RayeButton2](http://i.imgur.com/AdPoeiI.png)

1. Button에서 스타일을 RayeButton으로 지정합니다.
2. Background를 설정하여 버튼의 색을 변경 할 수 있습니다.
