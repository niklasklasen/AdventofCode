from urllib.request import urlopen
url = "https://adventofcode.com/2019/day/1"
message = 'Loading data from given input URL. Please hold...'
print(message)
website = urlopen(url)
html_b = website.read()
html = html_b.decode("utf-8")
print(html)
