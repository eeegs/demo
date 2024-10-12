# demo

This shows the binding issue refereced in: https://github.com/dotnet/maui/issues/25189

The issue is with this xmal:
```
    <FlexLayout BindableLayout.ItemsSource="{Binding Seats}"
                Direction="Row"
                BackgroundColor="AliceBlue">
        <BindableLayout.ItemTemplate>
            <DataTemplate>
                <Grid x:DataType="viewModels:Seat"
                      BackgroundColor="AntiqueWhite"
                      HeightRequest="80"
                      WidthRequest="80"
                      Margin="20">
                    <BoxView HeightRequest="80"
                             WidthRequest="80"
                             CornerRadius="15"
                             VerticalOptions="Center"
                             HorizontalOptions="Center"
                             Color="IndianRed" />
                    <local:PlayerControl IsVisible="{Binding IsOccupied}"
                                         BindingContext="{Binding Player}" />
                </Grid>
            </DataTemplate>
        </BindableLayout.ItemTemplate>
    </FlexLayout>
```

The PlayerControl IsVisible is trying to bind with "Player.IsOccupied" the DataContext passed to the PlayerControl and not the DataContect at this level a "Seat".


