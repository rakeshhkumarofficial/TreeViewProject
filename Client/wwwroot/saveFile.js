function saveFile(fileName, fileContent) {
    var link = document.createElement('a');
    link.download = fileName;
    link.href = "data:application/yaml;charset=utf-8," + encodeURIComponent(fileContent);
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
};
