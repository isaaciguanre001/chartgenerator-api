declare module '@apiverve/chartgenerator' {
  export interface chartgeneratorOptions {
    api_key: string;
    secure?: boolean;
  }

  export interface chartgeneratorResponse {
    status: string;
    error: string | null;
    data: ChartGeneratorData;
    code?: number;
  }


  interface ChartGeneratorData {
      id:          string;
      format:      string;
      expires:     number;
      type:        string;
      downloadURL: string;
  }

  export default class chartgeneratorWrapper {
    constructor(options: chartgeneratorOptions);

    execute(callback: (error: any, data: chartgeneratorResponse | null) => void): Promise<chartgeneratorResponse>;
    execute(query: Record<string, any>, callback: (error: any, data: chartgeneratorResponse | null) => void): Promise<chartgeneratorResponse>;
    execute(query?: Record<string, any>): Promise<chartgeneratorResponse>;
  }
}
