// @ts-check
import { themes as prismThemes } from "prism-react-renderer";

/** @type {import('@docusaurus/types').Config} */
const config = {
  title: "YomiNet",
  tagline: "中文网络工具箱",
  favicon: "img/favicon.ico",
  url: "https://leo-wit.github.io",
  baseUrl: "/YomiNet/",
  organizationName: "Leo-WIT",
  projectName: "YomiNet",
  trailingSlash: false,
  onBrokenLinks: "warn",
  onBrokenAnchors: "warn",
  markdown: {
    hooks: {
      onBrokenMarkdownLinks: "warn",
    },
  },
  i18n: {
    defaultLocale: "zh-CN",
    locales: ["zh-CN"],
  },
  headTags: [
    {
      tagName: "script",
      attributes: { type: "application/ld+json" },
      innerHTML: JSON.stringify({
        "@context": "https://schema.org",
        "@type": "SoftwareApplication",
        name: "YomiNet",
        applicationCategory: "NetworkApplication",
        operatingSystem: "Windows 10, Windows 11",
        softwareVersion: "2026.6.13.0",
        datePublished: "2026-06-13",
        dateModified: "2026-06-13",
        offers: { "@type": "Offer", price: "0", priceCurrency: "USD" },
        description: "用于管理网络和排查网络问题的中文工具箱。",
        url: "https://github.com/Leo-WIT/YomiNet",
        downloadUrl: "https://github.com/Leo-WIT/YomiNet/releases",
        author: { "@type": "Organization", name: "Leo-WIT" },
        license: "https://github.com/Leo-WIT/YomiNet/blob/main/LICENSE",
      }),
    },
  ],
  presets: [
    [
      "classic",
      ({
        docs: {
          sidebarPath: "./sidebars.js",
          editUrl: "https://github.com/Leo-WIT/YomiNet/tree/main/Website/",
        },
        blog: false,
        theme: {
          customCss: "./src/css/custom.css",
        },
      }),
    ],
  ],
  themeConfig: ({
    image: "img/social-card.png",
    metadata: [
      {
        name: "keywords",
        content: "YomiNet, 网络工具, IP 扫描, 端口扫描, Ping, DNS, WiFi, CIDR",
      },
      { name: "author", content: "Leo-WIT" },
    ],
    navbar: {
      title: "YomiNet",
      logo: { alt: "YomiNet Logo", src: "img/logo.svg" },
      items: [
        { to: "/download", label: "下载", position: "left" },
        { type: "docSidebar", sidebarId: "docsSidebar", position: "left", label: "文档" },
        { href: "https://github.com/Leo-WIT/YomiNet", label: "GitHub", position: "right" },
      ],
    },
    footer: {
      style: "dark",
      links: [
        {
          title: "链接",
          items: [
            { label: "下载", to: "/download" },
            { label: "GitHub", href: "https://github.com/Leo-WIT/YomiNet" },
          ],
        },
      ],
      copyright: "Copyright © 2026 Leo-WIT. Built with Docusaurus.",
    },
    prism: {
      theme: prismThemes.github,
      darkTheme: prismThemes.dracula,
      additionalLanguages: ["csharp", "json", "powershell"],
    },
  }),
};

export default config;
