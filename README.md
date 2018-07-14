# Knowrage-google-cloud-vision

## Overview

Google Cloud Vision APIを使用し、画像ファイル（動画ファイル）を解析することで、
画像ファイル（動画ファイル）に写しだされている物体をラベルとして抽出する。  
また、その抽出されたラベルを Microsoft Azure Translator API を使用し、日本語に翻訳する。

## Features

- Image Content analysis
- Video Content analysis

## Requirement

- Visual Studio 2017
- C# 7.2 or more
- .NET Framework 4.7 or more

## Installation

    $ git clone https://github.com/hiroki-Fukumoto/knowrage-google-cloud-vision.git

## Install

- 「NuGet パッケージの管理」から `Google.Cloud.Vision.V1` をインストール

# Authors

- HIROKI FUKUMOTO

# References
- [Vision API - 画像コンテンツ分析  |  Google Cloud](https://cloud.google.com/vision/)
- [Translator Text API - 自動翻訳 | Microsoft Azure](https://azure.microsoft.com/ja-jp/services/cognitive-services/translator-text-api/)
- [Method: images.annotate  |  Cloud Vision API  |  Google Cloud](https://cloud.google.com/vision/docs/reference/rest/v1/images/annotate)
- [画像認識API使ってみた（１）Google Cloud Vision - APIを探して、試して、使える【APIBank】](https://www.apibank.jp/use_google-cloud-vision/)
- [C#でGoogle Cloud PlatformのCloud Vision APIを使ってみよう (1/2)：Visual Studioで始めるGoogle Cloud Platformプログラミング - ＠IT](http://www.atmarkit.co.jp/ait/articles/1712/22/news033.html)
