<?php
include "simple_html_dom.php";
$html = file_get_html('http://localhost/htmlparser/Germany.html',false,null,0);
// Find all images 

$img="";
foreach($html->find('img') as $element) 
{$im= $element->src;$n=1;
$img=$im;//str_replace("small","medium",$im,$n);

}
if (file_exists($img)) {
    header('Content-Description: File Transfer');
    header('Content-Type: application/octet-stream');
    header('Content-Disposition: attachment; filename="'.basename($img).'"');
    readfile($img);
    exit;
}else echo $img;
	   ?>