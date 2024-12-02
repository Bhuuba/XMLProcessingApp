<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:output method="html" indent="yes" />
	
	<xsl:template match="/">
		<html>
			<body>
				<h1>Test Output</h1>
				<xsl:for-each select="library/book">
					<p>
						<xsl:value-of select="@title" />
					</p>
				</xsl:for-each>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
