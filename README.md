# How to change the EmptyViewTemplate at runtime in .NET MAUI ListView (SfListView)?

This demo shows about how to change the EmptyViewTemplate at runtime in .NET MAUI ListView (SfListView).

## Sample

```xaml
<ContentPage.Resources>
    <ResourceDictionary>
        <local:ListViewBoolToSortImageConverter x:Key="BoolToSortIconConverter"/>          
        <DataTemplate x:Key="BasicTemplate">
            <Label Text="{Binding .,StringFormat='{0} is not found'}" HorizontalTextAlignment="Center" VerticalOptions="CenterAndExpand"
                    FontSize="18" FontFamily="Roboto-Regular" TextColor="#666666" Margin="16,0,16,0"/>
        </DataTemplate>
        <DataTemplate  x:Key="AdvancedTemplate">
            <StackLayout VerticalOptions="CenterAndExpand">
                <Label Text="&#xe725;" FontSize="40" TextColor="#666666" Opacity="0.8"
                                FontFamily="{OnPlatform iOS=ListViewFontIcons, MacCatalyst=ListViewFontIcons, Android=ListViewFontIcons.ttf#, UWP=ListViewFontIcons.ttf#ListViewFontIcons}"
                                HorizontalTextAlignment="Center" VerticalTextAlignment="Center" />
                <Label Text="{Binding .,StringFormat='{0} is not found'}" TextColor="#666666" FontSize="16" FontFamily="Roboto-Regular" HorizontalTextAlignment="Center" VerticalTextAlignment="Center"  Margin="0,10,0,0"/>
            </StackLayout>
        </DataTemplate>
        <local:EmptyViewDataTemplateSelector x:Key="DataTemplateSelector" BasicTemplate="{StaticResource BasicTemplate}" AdvancedTemplate="{StaticResource AdvancedTemplate}"/>
    </ResourceDictionary>
</ContentPage.Resources>

<syncfusion:SfListView x:Name="listView" 
                    Grid.Row="3"
                    SelectionMode="None"                                     
                    ItemsSource="{Binding Items}"                      
                    ItemSize="56"
                    EmptyView="{Binding Source={x:Reference filterText},Path=Text}"
                    EmptyViewTemplate="{StaticResource DataTemplateSelector}">

    <syncfusion:SfListView.ItemTemplate>
        <DataTemplate x:Name="ItemTemplate">
            <Grid Margin="8">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="48"/>
                    <ColumnDefinition Width="*"/>
                    <ColumnDefinition Width="50"/>
                </Grid.ColumnDefinitions>
                <Frame HorizontalOptions="Start" IsClippedToBounds="True" CornerRadius="2" HasShadow="False"  Grid.Column="0" HeightRequest="40" WidthRequest="40" Padding="0">
                    <Image Grid.Column="0"  Source="{Binding ProductImage}" HeightRequest="40" WidthRequest="40" HorizontalOptions="Start"/>
                </Frame>
                <Label Grid.Column="1" Text="{Binding ProductName}" VerticalOptions="Center" FontSize="{OnPlatform Default=16,UWP=14}" FontFamily="Roboto-Regular" TextColor="#DE000000" CharacterSpacing="0.15"/>
                <Label Grid.Column="2" Text="{Binding Quantity}" VerticalOptions="Center" HorizontalTextAlignment="Center" HorizontalOptions="Center" FontSize="{OnPlatform Default=16,UWP=14}" FontFamily="Roboto-Regular" TextColor="#DE000000" WidthRequest="30"/>
            </Grid>
        </DataTemplate>
    </syncfusion:SfListView.ItemTemplate>
</syncfusion:SfListView>
```

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
