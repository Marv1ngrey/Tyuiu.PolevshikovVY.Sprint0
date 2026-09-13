for p in Tyuiu.PolevshikovVY.Sprint0.Task*/; do
  csproj=$(find "$p" -maxdepth 1 -name "*.csproj" 2>/dev/null | head -1)
  [ -n "$csproj" ] && dotnet sln Tyuiu.PolevshikovVY.Sprint0.sln add "$csproj"
done