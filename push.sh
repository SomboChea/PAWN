name=$(git rev-parse --abbrev-ref HEAD)
git push -u origin $name

echo "Press any to exit! $name"
read